using System.Text;

namespace Lab3
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddCamera_Click(object sender, EventArgs e)
        {
            Camera camera = new Camera(); fCamera fc = new fCamera(camera);
            if (fc.ShowDialog() == DialogResult.OK)
            {
                tbCamerasInfo.Text +=
                string.Format("{0}, {1}. Country: {2}. Sensor type: {3}, sensor resolution: {4} megapixels. " +
                "Lens type: {5}. Video format: {6}. {7} Full name: {8}",
                camera.Brand, camera.Model, camera.CountryOfOrigin, camera.SensorType, camera.SensorResolution, 
                camera.LensType, camera.VideoFormat, camera.WeatherSealing ? "The camera is protected against water and dust." :
                "The camera is not protected against water and dust.", camera.GetFullName());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Stop the application?", "Shut down.",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
/*tbCamerasInfo.Text +=
                string.Format("{0}, {1}. Country: {2}. Sensor type: {3}, sensor resolution: {4} megapixels. " +
                "Lens type: {5}. Video format: {6}. [{7} │ {8}] Full name: {9}",
                camera.Brand, camera.Model, camera.CountryOfOrigin, camera.SensorType, camera.SensorResolution, 
                camera.LensType, camera.VideoFormat,
                camera.WeatherSealing ? "The camera is protected against water and dust." : 
                "The camera is not protected against water and dust.", camera.GetFullName());*/