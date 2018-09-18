using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quizoman.Properties;

namespace Quizoman.View
{
    public partial class QuizzesView : UserControl
    {
        public QuizzesView()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            treeViewSeasons.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            treeViewSeasons.DrawNode += new DrawTreeNodeEventHandler(treeViewSeasons_DrawNode);
            treeViewSeasons.Width = 300;
        }



        void treeViewSeasons_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            Rectangle nodeRect = e.Node.Bounds;
            /*--------- 1. draw expand/collapse icon ---------*/
            Point ptExpand = new Point(nodeRect.Location.X - 20, nodeRect.Location.Y + 2);
            Brush borderBrush = new SolidBrush(Color.FromArgb(55, 55, 65));
            Rectangle b = e.Node.Bounds;
            Pen pen = new Pen(borderBrush);
            pen.Width = 1;
            b.X -= 23;
            b.Width = treeViewSeasons.Width;
            if ((e.State & TreeNodeStates.Focused) != 0)
            {
                if (e.Node.Level == 1)
                {
                    b.X -= 20;
                    b.Width += 20;
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(36, 38, 45)), b);

                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 40, 47)), b);

                }

            }
            else
            {
                if (e.Node.Level == 1)
                {

                    b.X -= 20;
                    b.Width += 20;
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(56, 56, 66)), b);

                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(58, 58, 68)), b);

                }

            }

            bool selected = e.Node == treeViewSeasons.SelectedNode;
            Image expandImg = null;
            if (e.Node.Parent == null && e.Node.Nodes.Count > 0)
            {
                if (e.Node.IsExpanded || e.Node.Nodes.Count < 1)
                {
                    if (selected)
                    {
                        expandImg = Resources.minus_fade;
                    }
                    else
                    {
                        expandImg = Resources.minus;
                    }
                }
                else
                {
                    if (selected)
                    {
                        expandImg = Resources.plus_fade;
                    }
                    else
                    {
                        expandImg = Resources.plus;
                    }
                }
                Graphics g = Graphics.FromImage(expandImg);
                IntPtr imgPtr = g.GetHdc();
                g.ReleaseHdc();
                e.Graphics.DrawImage(expandImg, ptExpand);
            }

            /*--------- 2. draw node icon ---------*/

            /*--------- 3. draw node text ---------*/
            Font nodeFont = e.Node.NodeFont;
            if (nodeFont == null)
                nodeFont = ((TreeView)sender).Font;
            Brush textBrush = new SolidBrush(Color.White);
            //to highlight the text when selected
            if ((e.State & TreeNodeStates.Focused) != 0)
            {

                textBrush = new SolidBrush(Color.FromArgb(174, 174, 178));
            }

            //Inflate to not be cut
            Rectangle textRect = nodeRect;
            textRect.Width = treeViewSeasons.Width;
            //need to extend node rect
            //textRect.Width += 40;
            e.Graphics.DrawString(e.Node.Text, nodeFont, textBrush, Rectangle.Inflate(textRect, -12, 0));
        }

        private void treeViewSeasons_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeViewSeasons.SelectedNode = e.Node;
            if (e.Node.IsExpanded)
            {
                e.Node.Collapse();
            }
            else
            {
                e.Node.Expand();
            }



        }

        private void treeViewSeasons_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {



        }

        private void treeViewSeasons_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {


        }
    }
}
