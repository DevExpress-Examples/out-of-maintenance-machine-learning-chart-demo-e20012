using System;
using ml.Math;
using System.IO;
using ml.Attributes;
using ml.Supervised;
using ml.Unsupervised;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using MachineLearningDemo.Data;
using System.Xml.Serialization;
using System.Linq;
using System.Threading;

namespace MachineLearningDemo
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        private IPredict<Student> _classifier;
        private Student[] _data;
        private Student _subject;

        private Feed[] _feedData;
        private TypeDescription _feedDescription;

        public Main()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            _data = StudentData.GetData();
            gridStudent.DataSource = _data;
            gridStudent.RefreshDataSource();
            _subject = new Student { Name = "Seth", GPA = 3.5, Age = 31, Grade = Grade.A, Tall = false, Friends = 15 };
            propertyStudent.SelectedObject = _subject;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (_data == null)
            {
                XtraMessageBox.Show("There is no data create model!", "Uh Oh!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var model = new PerceptronModel<Student>();
            _classifier = model.Generate(_data);
            XtraMessageBox.Show("Done!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSaveModel_Click(object sender, EventArgs e)
        {
            if (_classifier == null)
            {
                XtraMessageBox.Show("There is no model to save!", "Uh Oh!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dialogSaveModel.ShowDialog() == DialogResult.OK)
            {
                _classifier.Save(dialogSaveModel.FileName);
                XtraMessageBox.Show("Done!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonPredict_Click(object sender, EventArgs e)
        {
            if (_classifier == null)
            {
                XtraMessageBox.Show("There is no model to predict!", "Uh Oh!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _classifier.Predict(_subject);
            propertyStudent.Refresh();
            MessageBox.Show(string.Format("Looks like {0} is {1}!", _subject.Name, _subject.Good ? "good" : "not good"), "Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClusteStudents_Click(object sender, EventArgs e)
        {
            if (_data == null)
            {
                XtraMessageBox.Show("There is no data create cluster!", "Uh Oh!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int g = (int)spinClusterCount.Value;
            var kmeans = new KMeans<Student>();

            var grouping = kmeans.Generate(_data, g);

            for (int i = 0; i < grouping.Length; i++)
                _data[i].Cluster = grouping[i] + 1;

            gridStudent.DataSource = _data;
            gridStudent.RefreshDataSource();

            MessageBox.Show("Done!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClusterFeeds_Click(object sender, EventArgs e)
        {
            if (_feedData == null)
            {
                XtraMessageBox.Show("There is no data create cluster!", "Uh Oh!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cursor = Cursors.WaitCursor;

            int g = (int)spinFeedClusterCount.Value;
            var kmeans = new KMeans<Feed>();
            var grouping = kmeans.Generate(_feedData, g);
            _feedDescription = kmeans.Description;

            for (int i = 0; i < grouping.Length; i++)
                _feedData[i].Cluster = grouping[i] + 1;

            gridFeeds.DataSource = _feedData;
            gridFeeds.RefreshDataSource();

            Cursor = Cursors.Default;

            MessageBox.Show("Done!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonLoadFeeds_Click(object sender, EventArgs e)
        {
            _feedData = FeedData.GetData();
            gridFeeds.DataSource = _feedData;
            gridFeeds.RefreshDataSource();
        }

        private void buttonSaveDescription_Click(object sender, EventArgs e)
        {
            if (_feedDescription == null)
            {
                XtraMessageBox.Show("There is no description to save!", "Uh Oh!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dialogSaveModel.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(_feedDescription.GetType());
                using (var stream = File.OpenWrite(dialogSaveModel.FileName))
                {
                    serializer.Serialize(stream, _feedDescription);
                }
                XtraMessageBox.Show("Done!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonLoadPlot_Click(object sender, EventArgs e)
        {
            int n = 50;
            Cursor = Cursors.WaitCursor;
            chartLinear.Series[0].Points.Clear();
            chartLinear.Series[1].Points.Clear();

            Matrix reds = Matrix.Rand(n, 2) - .1;
            Matrix blue = Matrix.Rand(n, 2) - .9;

            for (int i = 0; i < n; i++)
            {
                chartLinear.Series[1].Points.Add(new SeriesPoint(reds[i, 0], reds[i, 1]));
                chartLinear.Series[0].Points.Add(new SeriesPoint(blue[i, 0], blue[i, 1]));
            }

            Cursor = Cursors.Default;
        }

        // Cluster data
        private Matrix _x;
        // Cluster centers
        private Matrix _means;
        // cluster assignments
        private int[] _assignments;

        private void buttonGenerateCluster_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int n = 100;
            _x = Matrix.Rand(n, 2) - .1;
            _x = _x.Stack(Matrix.Rand(n, 2) - .9);

            // Chart stuff
            chartCluster.Series[0].Points.Clear();
            chartCluster.Series[1].Points.Clear();
            chartCluster.Series[2].Points.Clear();
            chartCluster.Series[3].Points.Clear();
            for (int i = 0; i < 2 * n; i++)
                chartCluster.Series[1].Points.Add(new SeriesPoint(_x[i, 0], _x[i, 1]));

            buttonInitCluster.Enabled = true;
            Cursor = Cursors.Default;
        }

        
        private void buttonInitCluster_Click(object sender, EventArgs e)
        {
            Vector one = Vector.Rand(2) * .8;
            one[0] *= -1;
            Vector two = -one;

            _means = one.Stack(two);

            // chart stuff
            chartCluster.Series[2].Points.Clear();
            chartCluster.Series[3].Points.Clear();
            chartCluster.Series[2].Points.Add(new SeriesPoint(_means[0, 0], _means[0, 1]));
            chartCluster.Series[3].Points.Add(new SeriesPoint(_means[1, 0], _means[1, 1]));
            buttonAssign.Enabled = true;
        }

        
        private void buttonAssign_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            buttonUpdate.Enabled = true;

            AssignmentStep();

            Cursor = Cursors.Default;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            UpdateStep();
            Cursor = Cursors.Default;
        }


        private void AssignmentStep()
        {

            _assignments = (from x in _x.GetRows()
                            let z = (from d in _means.GetRows()
                                     select Vector.NormDiff(x, d))
                            select z.MinIndex())
                              .ToArray();

            // Chart Stuff
            chartCluster.Series[0].Points.Clear();
            chartCluster.Series[1].Points.Clear();
            for (int i = 0; i < _x.Rows; i++)
                chartCluster.Series[_assignments[i]].Points.Add(new SeriesPoint(_x[i, 0], _x[i, 1]));
        }


        private double UpdateStep()
        {
            var n = (from x in _x.GetRows()
                        .Zip(_assignments, (r, a) => new { Vec = r, Asgn = a })
                     group x by x.Asgn into grps
                     select grps
                        .Select(t => t.Vec)
                        .Average())
                    .ToMatrix();


            
            // Means matrix norm diff (for stopping)
            var diff = _means.GetRows()
                        .Zip(n.GetRows(), (v1, v2) => new { V1 = v1, V2 = v2 })
                        .Sum(a => Vector.NormDiff(a.V1, a.V2));

            _means = n;

            // chart stuff
            chartCluster.Series[2].Points.Clear();
            chartCluster.Series[3].Points.Clear();

            chartCluster.Series[2].Points.Add(new SeriesPoint(n[0, 0], n[0, 1]));
            chartCluster.Series[3].Points.Add(new SeriesPoint(n[1, 0], n[1, 1]));

            return diff;
        }

        private void buttonAnimate_Click(object sender, EventArgs e)
        {
            var diff = double.MaxValue;
            while (diff >= .00001)
            {
                AssignmentStep();
                Refresh();
                Thread.Sleep(500);
                diff = UpdateStep();
                Refresh();
                Thread.Sleep(500);
            }
        }
    }
}