using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Explode
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        public GamePage()
        {
            this.InitializeComponent();

            //
            b[0, 0] = bt00; b[1, 0] = bt10; b[2, 0] = bt20; b[3, 0] = bt30; b[4, 0] = bt40; b[5, 0] = bt50; b[6, 0] = bt60; b[7, 0] = bt70;
            b[0, 1] = bt01; b[1, 1] = bt11; b[2, 1] = bt21; b[3, 1] = bt31; b[4, 1] = bt41; b[5, 1] = bt51; b[6, 1] = bt61; b[7, 1] = bt71;
            b[0, 2] = bt02; b[1, 2] = bt12; b[2, 2] = bt22; b[3, 2] = bt32; b[4, 2] = bt42; b[5, 2] = bt52; b[6, 2] = bt62; b[7, 2] = bt72;
            b[0, 3] = bt03; b[1, 3] = bt13; b[2, 3] = bt23; b[3, 3] = bt33; b[4, 3] = bt43; b[5, 3] = bt53; b[6, 3] = bt63; b[7, 3] = bt73;
            b[0, 4] = bt04; b[1, 4] = bt14; b[2, 4] = bt24; b[3, 4] = bt34; b[4, 4] = bt44; b[5, 4] = bt54; b[6, 4] = bt64; b[7, 4] = bt74;
            b[0, 5] = bt05; b[1, 5] = bt15; b[2, 5] = bt25; b[3, 5] = bt35; b[4, 5] = bt45; b[5, 5] = bt55; b[6, 5] = bt65; b[7, 5] = bt75;
            b[0, 6] = bt06; b[1, 6] = bt16; b[2, 6] = bt26; b[3, 6] = bt36; b[4, 6] = bt46; b[5, 6] = bt56; b[6, 6] = bt66; b[7, 6] = bt76;




            //
        }
        player p1 = new player();
        player p2 = new player();
        int decideplayer = 0;
        int starttime = 0;


        Button[,] b = new Button[8, 8];






        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        private void bt00_Click(object sender, RoutedEventArgs e)
        {
            /* var brush = new ImageBrush();
             brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/threeballyellow.png"));
             b[0,0].Background = brush;*/
            setimg_onclick(sender, 0, 0);
        }

        private void bt01_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 0, 1);

        }

        private void bt02_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 0, 2);
        }

        private void bt03_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 0, 3);

        }

        private void bt04_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 0, 4);
        }

        private void bt05_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 0, 5);
        }

        private void bt06_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 0, 6);

        }

        private void bt07_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 0, 7);
        }

        private void bt10_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 1, 0);
        }

        private void bt11_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 1, 1);
        }

        private void bt12_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 1, 2);
        }

        private void bt13_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 1, 3);
        }

        private void bt14_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 1, 4);

        }

        private void bt15_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 1, 5);
        }

        private void bt16_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 1, 6);
        }

        private void bt17_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 1, 7);
        }

        private void bt20_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 2, 0);

        }

        private void bt21_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 2, 1);
        }

        private void bt22_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 2, 2);

        }

        private void bt23_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 2, 3);
        }

        private void bt24_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 2, 4);

        }

        private void bt25_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 2, 5);
        }

        private void bt26_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 2, 6);
        }

        private void bt27_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 2, 7);

        }

        private void bt30_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 3, 0);
        }

        private void bt31_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 3, 1);
        }

        private void bt32_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 3, 2);

        }

        private void bt33_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 3, 3);
        }

        private void bt34_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 3, 4);
        }

        private void bt35_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 3, 5);

        }

        private void bt36_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 3, 6);

        }

        private void bt37_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 3, 7);

        }

        private void bt40_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 4, 0);
        }

        private void bt41_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 4, 1);
        }

        private void bt42_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 4, 2);
        }

        private void bt43_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 4, 3);

        }

        private void bt44_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 4, 4);
        }

        private void bt45_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 4, 5);

        }

        private void bt46_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 4, 6);

        }

        private void bt47_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 4, 7);

        }

        private void bt50_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 5, 0);
        }

        private void bt51_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 5, 1);
        }

        private void bt52_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 5, 2);
        }

        private void bt53_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 5, 3);
        }

        private void bt54_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 5, 4);

        }

        private void bt55_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 5, 5);
        }

        private void bt56_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 5, 6);

        }

        private void bt57_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 5, 7);

        }

        private void bt60_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 6, 0);
        }

        private void bt61_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 6, 1);

        }

        private void bt62_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 6, 2);
        }
        private void bt63_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 6, 3);
        }

        private void bt64_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 6, 4);

        }

        private void bt65_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 6, 5);

        }

        private void bt66_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 6, 6);
        }

        private void bt67_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 6, 7);
        }
        private void bt70_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 7, 0);

        }
        private void bt71_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 7, 1);
        }

        private void bt72_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 7, 2);

        }

        private void bt73_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 7, 3);
        }

        private void bt74_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 7, 4);
        }

        private void bt75_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 7, 5);

        }

        private void bt76_Click(object sender, RoutedEventArgs e)
        {
            setimg_onclick(sender, 7, 6);

        }
        private void blast(object sender, player p, player op, int num_ways, int x, int y)
        {
            bleep.Play();
            var brush = new ImageBrush();
            if (x - 1 >= 0)
            {
                if (op.pos[x - 1, y] > 0)
                {
                    p.pos[x - 1, y] = op.pos[x - 1, y] + 1;

                }
                else
                {
                    p.pos[x - 1, y] = 1;
                    // check(sender, p, op, x - 1, y);
                }

                //
                var brush1 = new ImageBrush();
                if (decideplayer % 2 == 0)
                {//current player red


                    if (p.pos[x - 1, y] == 1)
                    {

                        brush1.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballred.png"));
                    }
                    else if (p.pos[x - 1, y] == 2)
                    {
                        brush1.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/twoballred.png"));
                    }

                    else if (p.pos[x - 1, y] == 3)
                    {
                        brush1.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/threeballred.png"));
                    }

                }
                else
                {

                    if (p.pos[x - 1, y] == 1)
                    {
                        brush1.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballyellow.png"));
                    }
                    else if (p.pos[x - 1, y] == 2)
                    {
                        brush1.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/twoballyellow.png"));
                    }

                    else if (p.pos[x - 1, y] == 3)
                    {
                        brush1.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/threeballyellow.png"));

                    }


                }
                Button bn = b[x - 1, y];
                bn.Background = brush1;

                if (num_ways == 4 && op.pos[x - 1, y] == 3)
                {
                    p.pos[x - 1, y] = 3;
                    check(sender, p, op, x - 1, y);

                }
                else if (num_ways == 3 && op.pos[x - 1, y] == 2)
                {
                    tb.Text = " " + p.pos[x - 1, y];
                    p.pos[x - 1, y] = 2;
                    check(sender, p, op, x - 1, y);
                }
                else if (num_ways == 2 && op.pos[x - 1, y] == 1)
                {
                    p.pos[x - 1, y] = 1;
                    check(sender, p, op, x - 1, y);
                }
                else
                {
                    //p.pos[x - 1, y]--;
                    op.pos[x - 1, y] = 0;
                    //check(sender, p, op, x - 1, y);
                }
                /*

                  if (op.pos[x - 1, y] > 0)
                  {
                      p.pos[x - 1, y] = op.pos[x - 1, y] + 1;
                      op.pos[x - 1, y] = 0;
                      p.pos[x - 1, y]--;
                  }
                  else
                  {   p.pos[x - 1, y]++;
                    
                  }
              
                  check(sender, p, op, x - 1, y);*/

                //
            }
            if (x + 1 <= 7)
            {
                var brush2 = new ImageBrush();

                if (op.pos[x + 1, y] > 0)
                {
                    p.pos[x + 1, y] = op.pos[x + 1, y] + 1;
                    //op.pos[x + 1, y] = 0;
                    //check(sender, p, op, x + 1, y);
                }
                else
                {
                    p.pos[x + 1, y] = 1;
                    //check(sender, p, op, x + 1, y);
                }

                //
                if (decideplayer % 2 == 0)
                {
                    if (p.pos[x + 1, y] == 1)
                    {
                        brush2.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballred.png"));

                    }
                    else if (p.pos[x + 1, y] == 2)
                    {

                        brush2.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/twoballred.png"));
                        //tb.Text = "\nopp  ind" + x + "  " + y + "    " + p.pos[x + 1, y] + "x+1......2 red set";
                    }

                    else if (p.pos[x + 1, y] == 3)
                    {
                        // tb.Text = "\nte....t";
                        brush2.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/threeballred.png"));
                    }

                }
                else
                {
                    if (p.pos[x + 1, y] == 1)
                    {
                        brush2.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballyellow.png"));
                    }
                    else if (p.pos[x + 1, y] == 2)
                    {
                        brush2.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/twoballyellow.png"));
                    }

                    else if (p.pos[x + 1, y] == 3)
                    {
                        brush2.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/threeballyellow.png"));
                    }


                }
                Button bn = b[x + 1, y];
                bn.Background = brush2;
                if (num_ways == 4 && op.pos[x + 1, y] == 3)
                {
                    p.pos[x + 1, y] = 3;
                    check(sender, p, op, x + 1, y);
                }
                else if (num_ways == 3 && op.pos[x + 1, y] == 2)
                {
                    p.pos[x + 1, y] = 2;
                    check(sender, p, op, x + 1, y);
                }
                else if (num_ways == 2 && op.pos[x + 1, y] == 1)
                {
                    p.pos[x + 1, y] = 1;
                    check(sender, p, op, x + 1, y);
                }
                else
                {
                    // p.pos[x + 1, y]--;
                    op.pos[x + 1, y] = 0;
                    //check(sender, p, op, x + 1, y);
                }
                /*   
               if (op.pos[x +1, y] > 0)
               {
                   p.pos[x + 1, y] = op.pos[x +1, y] + 1;
                   op.pos[x +1, y] = 0;
                 //  p.pos[x + 1, y]--;
               }
               else
               {
                   p.pos[x + 1, y]++;

               }
              
               check(sender, p, op, x + 1, y);*/

                //
            }

            if (y - 1 >= 0)
            {
                var brush3 = new ImageBrush();

                if (op.pos[x, y - 1] > 0)
                {
                    p.pos[x, y - 1] = op.pos[x, y - 1] + 1;
                    //op.pos[x , y-1] = 0;
                    //check(sender, p, op, x , y-1);
                }
                else
                {
                    p.pos[x, y - 1] = 1;
                    // check(sender, p, op, x, y - 1);
                }

                if (decideplayer % 2 == 0)
                {
                    if (p.pos[x, y - 1] == 1)
                    {
                        brush3.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballred.png"));

                    }
                    else if (p.pos[x, y - 1] == 2)
                    {
                        brush3.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/twoballred.png"));
                        //tb.Text = "\nopp  ind" + x + "  " + y + "    " + p.pos[x , y-1] + "y-1.......2 red set";
                    }

                    else if (p.pos[x, y - 1] == 3)
                    {
                        brush3.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/threeballred.png"));
                    }

                }
                else
                {


                    if (p.pos[x, y - 1] == 1)
                    {
                        brush3.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballyellow.png"));
                    }
                    else if (p.pos[x, y - 1] == 2)
                    {
                        brush3.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/twoballyellow.png"));
                    }

                    else if (p.pos[x, y - 1] == 3)
                    {

                        brush3.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/threeballyellow.png"));
                    }


                }
                Button bn = b[x, y - 1];

                bn.Background = brush3;

                if (num_ways == 4 && op.pos[x, y - 1] == 3)
                {
                    p.pos[x, y - 1] = 3;
                    check(sender, p, op, x, y - 1);
                }
                else if (num_ways == 3 && op.pos[x, y - 1] == 2)
                {
                    p.pos[x, y - 1] = 2;
                    check(sender, p, op, x, y - 1);
                }
                else if (num_ways == 2 && op.pos[x, y - 1] == 1)
                {
                    p.pos[x, y - 1] = 1;
                    check(sender, p, op, x, y - 1);
                }
                else
                {
                    //p.pos[x , y-1]--;
                    op.pos[x, y - 1] = 0;
                    //check(sender, p, op, x , y-1);
                }    /*   
               if (op.pos[x , y-1] > 0)
               {
                   p.pos[x, y - 1] = op.pos[x , y-1] + 1;
                   op.pos[x, y - 1] = 0;
                  // p.pos[x, y - 1]--;
               }
               else
               {
                   p.pos[x, y - 1]++;

               }
              
               check(sender, p, op, x , y-1);*/

            }
            if (y + 1 <= 6)
            {
                var brush4 = new ImageBrush();
                if (op.pos[x, y + 1] > 0)
                {
                    p.pos[x, y + 1] = op.pos[x, y + 1] + 1;
                    //op.pos[x, y+1] = 0;
                    //  check(sender, p, op, x, y +1);
                }
                else
                {
                    p.pos[x, y + 1] = 1;
                }

                //
                if (decideplayer % 2 == 0)
                {
                    if (p.pos[x, y + 1] == 1)
                    {
                        brush4.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballred.png"));
                    }
                    else if (p.pos[x, y + 1] == 2)
                    {
                        brush4.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/twoballred.png"));
                    }

                    else if (p.pos[x, y + 1] == 3)
                    {
                        brush4.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/threeballred.png"));
                    }

                }
                else
                {
                    if (p.pos[x, y + 1] == 1)
                    {
                        brush4.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballyellow.png"));
                    }
                    else if (p.pos[x, y + 1] == 2)
                    {
                        brush4.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/twoballyellow.png"));
                    }

                    else if (p.pos[x, y + 1] == 3)
                    {
                        brush4.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/threeballyellow.png"));
                    }


                }
                Button bn = b[x, y + 1];
                bn.Background = brush4;
                if (num_ways == 4 && op.pos[x, y + 1] == 3)
                {
                    p.pos[x, y + 1] = 3;
                    check(sender, p, op, x, y + 1);
                }
                else if (num_ways == 3 && op.pos[x, y + 1] == 2)
                {
                    p.pos[x, y + 1] = 2;
                    check(sender, p, op, x, y + 1);
                }
                else if (num_ways == 2 && op.pos[x, y + 1] == 1)
                {
                    p.pos[x, y + 1] = 1;
                    check(sender, p, op, x, y + 1);
                }
                else
                {
                    //p.pos[x, y+1]--;
                    op.pos[x, y + 1] = 0;
                    //check(sender, p, op, x, y + 1);

                }
            }
            /* 
           if (op.pos[x, y + 1] > 0)
           {
               p.pos[x, y + 1] = op.pos[x, y + 1] + 1;
               op.pos[x, y + 1] = 0;
              // p.pos[x, y + 1]--;
           }
           else
           {
               p.pos[x, y + 1]++;

           }
         
           check(sender, p, op, x, y + 1);*/
        }


        private void check(object sender, player p, player op, int x, int y)
        {
            if ((x == 0 || x == 7) && (y == 0 || y == 6)) // corners
            {
                // tb.Text  = "  corner  " + p.pos[x, y] + "  x :  " + x + "  y  :" + y;
                if (p.pos[x, y] == 1)
                {
                    blast(sender, p, op, 2, x, y);
                    p.pos[x, y] = 0;
                    op.pos[x, y] = 0;
                    var brush = new ImageBrush();
                    brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/transparent.png"));
                    b[x, y].Background = brush;
                }
                else
                {

                    var brush5 = new ImageBrush();
                    if (decideplayer % 2 == 0)
                    {
                        brush5.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballred.png"));
                        Button bn = (Button)sender;
                        bn.Background = brush5;
                        bn.UpdateLayout();
                    }
                    else
                    {

                        brush5.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballyellow.png"));
                        Button bn = (Button)sender;
                        bn.Background = brush5;
                    }
                    p.pos[x, y]++;
                }

            }

            else if ((x > 0 && x < 7) && (y > 0 && y < 6))  //middle
            {

                if (p.pos[x, y] == 3)
                {
                    blast(sender, p, op, 4, x, y);
                    p.pos[x, y] = 0;
                    op.pos[x, y] = 0;
                    var brush = new ImageBrush();
                    brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/transparent.png"));
                    b[x, y].Background = brush;
                }
                else
                {

                    var brush = new ImageBrush();
                    if (decideplayer % 2 == 0)
                    {
                        if (p.pos[x, y] == 0)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballred.png"));
                        }
                        else if (p.pos[x, y] == 1)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/twoballred.png"));
                        }

                        else if (p.pos[x, y] == 2)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/threeballred.png"));
                        }

                        Button bn = (Button)sender;
                        bn.Background = brush; bn.Foreground = brush;
                        bn.Foreground = brush;


                    }
                    else
                    {
                        if (p.pos[x, y] == 0)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballyellow.png"));
                        }
                        else if (p.pos[x, y] == 1)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/twoballyellow.png"));
                        }

                        else if (p.pos[x, y] == 2)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/threeballyellow.png"));
                        }
                        //brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballyellow.png"));

                        Button bn = (Button)sender;
                        bn.Background = brush; bn.Foreground = brush;
                        bn.Foreground = brush;


                    }
                    p.pos[x, y]++;
                }
            }
            else if (((x == 0 || x == 7) && (y > 0 && y < 6)) || ((y == 0 || y == 6) && (x > 0 && x < 7)))
            {
                // tb.Text  = "  sidemid " + p.pos[x, y]+"  x :  "+x+"  y  :"+y;

                if (p.pos[x, y] == 2)
                {
                    blast(sender, p, op, 3, x, y);
                    p.pos[x, y] = 0;
                    op.pos[x, y] = 0;
                    var brush = new ImageBrush();
                    brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/transparent.png"));
                    b[x, y].Background = brush;
                }
                else
                {

                    var brush = new ImageBrush();
                    if (decideplayer % 2 == 0)
                    {
                        if (p.pos[x, y] == 0)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballred.png"));
                        }
                        else if (p.pos[x, y] == 1)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/twoballred.png"));
                        }

                        Button bn = (Button)sender;
                        bn.Background = brush; bn.Foreground = brush;

                    }
                    else
                    {
                        if (p.pos[x, y] == 0)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballyellow.png"));
                        }
                        else if (p.pos[x, y] == 1)
                        {
                            brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/twoballyellow.png"));
                        }

                        //brush.ImageSource = new BitmapImage(new Uri("ms-appx:/Assets/oneballyellow.png"));

                        Button bn = (Button)sender;
                        bn.Background = brush; bn.Foreground = brush;

                    }
                    p.pos[x, y]++;
                }

            }



        }
        private bool checkif_notoccupied(player p, player op, int x, int y)
        {
            if (op.pos[x, y] == 0)
                return true;
            else
                return false;
        }

        /*  private void setimg_onclick(object sender,int x,int y)
          {
              int flag = 0;
           
                 // tb.Text = "YELLOW CHANCE...";
              if (decideplayer % 2 == 0)
              {
                
               
                  if (checkif_notoccupied(p1, p2, x, y))
                  {
                      tb.Text = "YELLOW PLAYER CHANCE...";
                      check(sender,p1, p2, x, y);
                      if (flag != 0)
                          check_numofplayerballs(p1, p2);
                      flag = 1;
                    
                      decideplayer++;
                  }
               
                
              
              }
              else
              {
                
                  if (checkif_notoccupied(p2, p1, x, y))
                  {
                      tb.Text = "RED PLAYER CHANCE...";
                      check(sender,p2, p1, x, y);
                      //decideplayer++;
                      if (flag != 0)
                          check_numofplayerballs(p1, p2);
                      flag = 1;
                      decideplayer++;
                  }
                
              }
             // if (starttime != 0)
              //{
                

              //} starttime = 1;
     
          }

          private void check_numofplayerballs(player p1, player p2)
          {  
            
              int p1_flag = 0, p2_flag = 0;
              for (int i = 0; i < 8; i++)
              {
                  for (int j = 0; j < 7; j++)
                  {
                      if(p1.pos[i, j]!=0)
                          p1_flag=1;
                    
                    

                      if (p2.pos[i, j] != 0)
                          p2_flag = 1;
                  }
              }
            
              if (p1_flag== 0)
              { tb.Text = "yellow wins";
              this.Frame.Navigate(typeof(winner), tb.Text);
              }
              else if (p2_flag == 0)
              { tb.Text = "red wins ";
              this.Frame.Navigate(typeof(winner), tb.Text);
              }
         
          }
        
       
       */

        private void setimg_onclick(object sender, int x, int y)
        {
            if (starttime == 0)
                tb.Text = "YELLOW CHANCE...";
            if (decideplayer % 2 == 0)
            {

                if (checkif_notoccupied(p1, p2, x, y))
                {
                    check(sender, p1, p2, x, y);
                    decideplayer++;
                }

            }
            else
            {

                if (checkif_notoccupied(p2, p1, x, y))
                {
                    check(sender, p2, p1, x, y);
                    decideplayer++;
                }
            }
            if (starttime != 0)
            {
                check_numofplayerballs(p1, p2);

            } starttime = 1;

        }

        private void check_numofplayerballs(player p1, player p2)
        {  
            if (decideplayer % 2 == 0)
            {
                tb.Text = "RED CHANCE...";

            }
            else
            {
                tb.Text = "YELLOW CHANCE...";
            }
            int p1_sum = 0, p2_sum = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    p1_sum += p1.pos[i, j];
                    p2_sum += p2.pos[i, j];
                }
            }
            if (p1_sum == 0)
            { tb.Text = "yellow wins";
            this.Frame.Navigate(typeof(winner), tb.Text);
            }
            else if (p2_sum == 0)
            {
                tb.Text = "red wins ";
                this.Frame.Navigate(typeof(winner), tb.Text);
            }

        }


    }



}
