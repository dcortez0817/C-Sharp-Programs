/*Darien Cortez
 * Program 7
 * 11/14/2018
 * This program utilizes the graphics class included in the
 * System.Drawing library to illustrate a landscape of hills 
 * and trees surrounded by birds flying in a sky full of clouds.
 */
using System.Drawing;
using System.Windows.Forms;

namespace Art
{
    public partial class Art : Form
    {
        public Art()
        {
            InitializeComponent();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Canvas.CreateGraphics();//gets graphics object

            //initializes different brushes based on color
            SolidBrush bluebrush = new SolidBrush(Color.PaleTurquoise);
            SolidBrush whitebrush = new SolidBrush(Color.White);
            SolidBrush greenbrush = new SolidBrush(Color.Green);
            SolidBrush orangebrush = new SolidBrush(Color.Orange);
            SolidBrush brownbrush = new SolidBrush(Color.Brown);

            Pen pen = new Pen(Color.Black);//pen for drawing

            g.FillEllipse(orangebrush, 30, 30, 60, 60);//sun

            //fills 4 circles dynamically througout the sky to act as clouds
            for (int i = 0; i <= 1200; i += 200)
            {
                g.FillEllipse(whitebrush, i + 180, 25, 30, 30);//left circle
                g.FillEllipse(whitebrush, i + 200, 20, 30, 30);//topcircle
                g.FillEllipse(whitebrush, i + 200, 30, 30, 30);//bottom circle
                g.FillEllipse(whitebrush, i + 220, 25, 30, 30);//right circle
            }

            //draws birds across the panel
            for (int i = 0; i <= 1200; i += 200)
            {
                g.DrawArc(pen, i + 150, 100, 15, 15, 180, 160);//left wing
                g.DrawArc(pen, i + 165, 100, 15, 15, 180, 180);//right wing
                g.DrawArc(pen, i + 200, 100, 15, 15, 180, 160);//left wing
                g.DrawArc(pen, i + 215, 100, 15, 15, 180, 180);//right wing
                g.DrawArc(pen, i + 175, 120, 10, 10, 180, 160);//left wing
                g.DrawArc(pen, i + 185, 120, 10, 10, 180, 180);//right wing
            }

            //dynamically fills ovals to act as hills
            for (int i = 0; i <= 1200; i += 400)
            {
                g.FillEllipse(greenbrush, i - 50, 275, 630, 180);//hills
                g.DrawArc(pen, i - 50, 275, 630, 180, 180, 180);//outline for hill
                //cuts off other half of circle to act as hill
                g.FillRectangle(bluebrush, i - 50, 365, 630, 90);
            }

            //dynamically fills rectangles and circles to represent trees
            for (int i = 0; i <= 1200; i += 400)
            {
                g.FillRectangle(brownbrush, i + 450, 215, 30, 80);//tree trunk
                g.FillEllipse(greenbrush, i + 405, 120, 120, 120);//leaves
                g.FillEllipse(greenbrush, i + 460, 150, 100, 100);//leaves
                g.FillEllipse(greenbrush, i + 360, 150, 100, 100);//leaves
            }
        }
    }
}
