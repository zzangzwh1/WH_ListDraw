//*************************************************************************************************
//Program:          CMPE1666
//Description:      using stack and linked list draw lines and remove segments, line and change the complexity
//                  when user click righr click it will get randome thinkcess and color 
//Date:             2021 04 13
//Author:           Wonhyuk Cho
//Course:           CMPE16666

//Instructor:      Simon Walker
//created : 2021 04 12
//finished : 2021 04 13
//*************************************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;


namespace ICA09_StackyListDraw
{
    public partial class Form1 : Form
    {
        //gdi draw set width :1024 height : 768
        CDrawer drawer = new CDrawer(1024, 768);

        //stack linklist line seg
        Stack<LinkedList<LineSeg>> StkA = new Stack<LinkedList<LineSeg>>();
        //bool flag for check whether drawing availabilty
        bool flag = false;
        //point start as 0,0
        Point start = new Point(0,0);
        //color change 
        Color colorChanged;
        int cnt =  0;
        //struct lineseg
        struct LineSeg
        {
            // point start point end point, thinckess of segments, alpha and color of segments
            public Point p;
            public Point pt;
            public byte thickness;
            public float alpha;
            public Color c;
            //constructor and instances point p , pt, color c, thickess and alpha
            public LineSeg(Point p, Point pt, Color c, byte thickness, float alpha)
            {
                this.p = p;
                this.pt = pt;
                this.c = c;
                this.thickness = thickness;
                this.alpha = alpha;
            }

        }
        // setting track bar value
        public byte setTrackValue {
            set
            {
                Ui_numBar.Value = value;
            }
           
        }
        public float setOpacityValue {
            set
            {
                UI_tBar_opacity.Value = (int)value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            UI_lbl_Result.Text = "0 lines, 0 total Segments.".ToString();
            //track bar value  will be 20 when installed
            setTrackValue = 20;
            setOpacityValue = 255;
            UI_lbl_thickness.Text ="Thickness:" + Ui_numBar.Value.ToString();
            UI_lbl_opacity.Text = "Alpha" + UI_tBar_opacity.Value.ToString();
          

        }
        //*************************************************************************************************
        //Program:          CMPE1666
        //Description:              private void timer1_Tick(object sender, EventArgs e)
        //                 when gdi drawer left clicked it start draw when right clicked it will stop 
        //Date:             2021 04 13
        //Author:           Wonhyuk Cho
        //Course:           CMPE16666

        //Instructor:      Simon Walker
        //created : 2021 04 12
        //finished : 2021 04 13
        //*************************************************************************************************
        private void timer1_Tick(object sender, EventArgs e)
        {
            //drawer mouse left click for the statring point
            if (drawer.GetLastMouseLeftClick(out Point tempPoint))
            {
                drawer.GetLastMouseLeftClick(out start);
            
            }
         
            //when x position is not 0 and bollean is false
            if((start.X != 0) && (flag == false))
            {
                //linklist lineseg
                LinkedList<LineSeg> lineSeg = new LinkedList<LineSeg>();
                //push into stack of lineseg
                StkA.Push(lineSeg);
                //flag is true 
                flag = true;

            }
            // mouse position end point
            drawer.GetLastMousePosition(out Point endpoint);

              //when start point is not end point and flag is true
            if((start != endpoint) && (flag == true))
            {               
               //line seg of starting point , end point color from color dialog, trackbar value and alpha
               LineSeg myLine = new LineSeg(start, endpoint, UI_CDG.Color, (byte)Ui_numBar.Value, (float) UI_tBar_opacity.Value);
                // option1 for push stack
                /* LinkedList<LineSeg> LL = StkA.Pop();
                 LL.AddLast(myLine);
                 StkA.Push(LL);*/


             
                //option2
                //add last linese intto stack peek
                StkA.Peek().AddLast(myLine);
                //redner the line
                Render(myLine);
                //start is end point
                start = endpoint;
                PrintValue();

            }
            //when right button clicked
            if(drawer.GetLastMouseRightClick(out Point temp2) && (flag == true))
            {
                //flage is false
                flag = false;
                //start point is 0
                start = new Point(0,0);
            }
          
            
        }
        //rendering line
        private void Render(LineSeg li)
        {
            //getting instances for adding lines
            drawer.AddLine(li.p.X, li.p.Y, li.pt.X, li.pt.Y, Color.FromArgb((int)li.alpha, li.c.R, li.c.G, li.c.B), li.thickness) ;
          
           

        }
        //*************************************************************************************************
        //Program:          CMPE1666
        //Description:                    private void UI_btn_color_Click(object sender, EventArgs e)
        //               when color button clicked it will show dilog
        //Date:             2021 04 13
        //Author:           Wonhyuk Cho
        //Course:           CMPE16666

        //Instructor:      Simon Walker
        //created : 2021 04 12
        //finished : 2021 04 13
        //*************************************************************************************************
        private void UI_btn_color_Click(object sender, EventArgs e)
        {
            //when ok button clicked
            if(UI_CDG.ShowDialog() == DialogResult.OK)
            {
                //color change is color dialog color
                colorChanged = UI_CDG.Color;
       
            }
        }
        //*************************************************************************************************
        //Program:          CMPE1666
        //Description:                            private void Ui_numBar_Scroll(object sender, EventArgs e)
        //              when numbar scrolled label we initilized the trackbar value
        //Date:             2021 04 13
        //Author:           Wonhyuk Cho
        //Course:           CMPE16666

        //Instructor:      Simon Walker
        //created : 2021 04 12
        //finished : 2021 04 13
        //*************************************************************************************************
        private void Ui_numBar_Scroll(object sender, EventArgs e)
        {
            //track bar value text
            UI_lbl_thickness.Text = "Thickness:" + Ui_numBar.Value.ToString();
         
        }
        //*************************************************************************************************
        //Program:          CMPE1666
        //Description:    private void UI_btn_segment_Click(object sender, EventArgs e)
        //              when segment button clicked check the stack if is is not empty and remove  the segments
        //Date:             2021 04 13
        //Author:           Wonhyuk Cho
        //Course:           CMPE16666

        //Instructor:      Simon Walker
        //created : 2021 04 12
        //finished : 2021 04 13
        //*************************************************************************************************
        private void UI_btn_segment_Click(object sender, EventArgs e)
        {
            //when stack is not empty
            if (StkA.Count > 0)
            {
                //lineseg is stack peak
                LinkedList<LineSeg> LL = StkA.Peek();
                //remove the last 
                LL.RemoveLast();
                //rednerline clear
                RenderClear();
                // when stack is 0
                if(StkA.Peek().Count ==0)
                {
                    //pop the stack
                    StkA.Pop();
                }
                PrintValue();
            } 

        }
        //*************************************************************************************************
        //Program:          CMPE1666
        //Description:     private void UI_btn_line_Click(object sender, EventArgs e)
        //              when undo line button clicked remove the line
        //Date:             2021 04 13
        //Author:           Wonhyuk Cho
        //Course:           CMPE16666

        //Instructor:      Simon Walker
        //created : 2021 04 12
        //finished : 2021 04 13
        //*************************************************************************************************
        private void UI_btn_line_Click(object sender, EventArgs e)
        {
         //when stack count is not empty
            if(StkA.Count != 0)
            {
                //linkline is stack pop
                LinkedList<LineSeg> LL = StkA.Pop();
                //remove the recent
                LL.RemoveLast();
                //clear the line 
                RenderClear();
                //print the value
                PrintValue();
            }
           

        }
        //*************************************************************************************************
        //Program:          CMPE1666
        //Description:            private void RenderClear()
        //             clear the drawer 
        //Date:             2021 04 13
        //Author:           Wonhyuk Cho
        //Course:           CMPE16666

        //Instructor:      Simon Walker
        //created : 2021 04 12
        //finished : 2021 04 13
        //*************************************************************************************************
        private void RenderClear()
        {
            //drawer clear
            drawer.Clear();
            //check stack in line linklist
            foreach(LinkedList<LineSeg> link in StkA)
            {
                //check linklist in line seg
                foreach (LineSeg line in link) 
                {
                    //draw line 
                   // drawer.AddLine(li.p.X, li.p.Y, li.pt.X, li.pt.Y, Color.FromArgb((int)li.alpha, li.c.R, li.c.G, li.c.B), li.thickness);
                    drawer.AddLine(line.p.X, line.p.Y, line.pt.X, line.pt.Y, Color.FromArgb((int)line.alpha, line.c.R, line.c.G, line.c.B), line.thickness);

                }
            }
        }
        //*************************************************************************************************
        //Program:          CMPE1666
        //Description:              private void UI_btn_Reduce_Click(object sender, EventArgs e)
        //         complixty the line 
        //Date:             2021 04 13
        //Author:           Wonhyuk Cho
        //Course:           CMPE16666

        //Instructor:      Simon Walker
        //created : 2021 04 12
        //finished : 2021 04 13
        //*************************************************************************************************
        private void UI_btn_Reduce_Click(object sender, EventArgs e)
        {
            //when stack count and stack peak count is over 0 and over 1
            if(StkA.Count > 0 && StkA.Peek().Count > 1)
            {
                //create line as stack pop
                LinkedList<LineSeg> line = StkA.Pop();
                //create temp for the lineseg linklist
                LinkedList<LineSeg> temp = new LinkedList<LineSeg>();
                //scan the linklist node for the first line
                LinkedListNode<LineSeg> scan = line.First;

                //when scan is not null
                while(scan != null)
                {
                    //linese as new line
                    LineSeg newline = new LineSeg();

                    //when scan is not null
                    if(scan.Next != null)
                    {
                        //newline first point is scan firstpoint
                        newline.p = scan.Value.p;
                        //newlist thckess is scnas' thickess
                        newline.thickness = scan.Value.thickness;
                        //newline color = scna's color
                        newline.c = scan.Value.c;
                        //newline alpha = scans' alpha
                        newline.alpha = scan.Value.alpha;       
                        //scan next for the next point
                        scan = scan.Next;
                        //newline endpoint = sans' endpoint
                        newline.pt = scan.Value.pt;

                        //scan next
                        scan = scan.Next;
                        //add into temp
                        temp.AddLast(newline);
                    }
                    //when point is even
                    else
                    {
                        // newline = scnas value
                        
                        newline = scan.Value;
                        //add newline into temp
                        temp.AddLast(newline);
                        scan = scan.Next;
                    }
                }
                //stack push the temp value
                StkA.Push(temp);
                //render clear
                RenderClear();
                //print
                PrintValue();
            }
          

           
        }
        //print value 
        private void PrintValue()
        {
            //cnt as 0
            int cnt = 0;
            //check all the liniklist in stack
            foreach (LinkedList<LineSeg> link in StkA)
            {
                //check all the lineseg in the linklist
                foreach (LineSeg line in link)
                {
                    //count up
                    cnt++;                
                }
            }
            // pringing value
                    UI_lbl_Result.Text = StkA.Count.ToString() + "lines, " + cnt.ToString() + " total Segments.";
        }

        // opacity change value
        private void UI_tBar_opacity_Scroll(object sender, EventArgs e)
        {
            UI_lbl_opacity.Text = "Alpha:" + UI_tBar_opacity.Value.ToString();
            setOpacityValue = UI_tBar_opacity.Value;
        }
    }
}
