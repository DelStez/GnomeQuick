using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace GnomeQuick
{
    public partial class Form1 : Form
    {
        public const int RUN = 32;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }
        int swapping = 0; int comprassion = 0; int swapping1 = 0; int comprassion2 = 0;
        public List<int> numb = new List<int>();
        public List<string> FilesPath = new List<string>();
        public PointPairList list = new PointPairList ();
        public PointPairList list2 = new PointPairList ();
        public PointPairList list3 = new PointPairList ();
        public PointPairList list4 = new PointPairList ();
        public PointPairList list5 = new PointPairList ();
        public PointPairList list6  = new PointPairList ();
        public List<double> sizes = new List<double>();
        public List<double> times1 = new List<double>();
        public List<double> times2 = new List<double>();
        public List<double> swapping_List = new List<double>();
        public List<double> swapping2_List = new List<double>();
        public List<double> comprassion_List = new List<double>();
        public List<double> comprassion2_List = new List<double>();

        public void DrawTimeSize(double size1, double time1, double time2, GraphPane pane, PointPairList x, PointPairList y, string text, string text1)
        {
            Random rnd = new Random ();
            pane.CurveList.Clear ();
            double ymax = ( (time1 * 1000) + 10 + (time2 * 1000) + 10) / 2;
            // Заполняем список точек
            x.Add (size1, time1 * 1000);
            y.Add (size1, time2 * 1000);
            // Создадим кривую
            pane.AddCurve (text, x, Color.Purple, SymbolType.Circle);
            pane.AddCurve (text1, y, Color.Firebrick, SymbolType.Diamond);
            pane.Legend.IsVisible = true;

        }

        private void Load_Click(object sender, EventArgs e)
        {
            Cleaning();
            textBox2.Clear();
            FilesPath.Clear();
            button2.Enabled = true;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Текстовый файл (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            
            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    FilesPath.Add(fileName);
                    textBox2.Text += fileName + ":\r\n";
                    string content = File.ReadAllText(fileName);
                    string[] texfile = content.Split(new string[] { "\n", " ", "\0" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string n in texfile)
                    {
                        textBox2.Text += n.ToString() + "\r\n";
                    } 
                    
                }
            }
        }
        private bool CheckingAllNumber(string fileName)
        {
            bool isDigitOnly = true;
            using (StreamReader reader = new StreamReader(fileName))
            {
                int nextChar = reader.Read();
                while (nextChar != -1)
                {
                    if (!char.IsDigit((char)nextChar) && nextChar != ' ' && nextChar != '.')
                    {
                        isDigitOnly = false;
                        break;
                    }
                    nextChar = reader.Read();
                }
            }
            if (!isDigitOnly)
            {
                MessageBox.Show("Файл содержит недопустимые символы.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private List<int> preStart(string FileName)
        {
            //
            string content = File.ReadAllText(FileName);
            string[] texfile = content.Split(new string[] { "\n", " ", "\0" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string Line in texfile)
            {
                int[] temp = Line.Split(new char[] { '\n', ' ', '\r' }).Select(int.Parse).ToArray();
                for (int i = 0; i < temp.Length; i++)
                {
                    numb.Add(temp[i]);
                }
            }

            return numb;
        }

        private void start_Click(object sender, EventArgs e)
        {
            Cleaning();
            foreach (var path in FilesPath)
            {
                List<int> numb = preStart(path);
                sizes.Add(numb.Count);
                textBox1.Text += path + ":\r\n";
                var Start = DateTime.Now;
                List<int> result = gnomeSort(numb.ToArray(), numb.Count);
                var spendtime = DateTime.Now - Start;
                times1.Add(spendtime.TotalMilliseconds);
                textBox3.Text += path + ":\r\n";
                foreach (int n in result)
                {
                    textBox3.Text += n.ToString() + "\r\n";
                }
                swapping_List.Add(swapping);
                comprassion_List.Add(comprassion);
                numb.Clear();
                textBox1.Text += "Gnom:" + "\r\n";
                textBox1.Text += "Время:   " + spendtime.Milliseconds + " мс" + "\r\n";
                textBox1.Text += "Кол-во перестановок: " + swapping.ToString() + ":\r\n";
                textBox1.Text += "Кол-во сравнений: " + comprassion.ToString() + ":\r\n";
                
                
                
                numb= preStart(path);
                var spendTimeForOne = spendtime;
                Start = DateTime.Now;
                result = timSort(numb.ToArray(), numb.Count);
                spendtime = DateTime.Now - Start;
                textBox4.Text += path +":\r\n";
                foreach (int n in result)
                {
                    textBox4.Text += n.ToString() + "\r\n";
                }
                times2.Add(spendtime.TotalMilliseconds);
                swapping2_List.Add(swapping1);
                comprassion2_List.Add(comprassion2);
                numb.Clear();
                textBox1.Text += "Trim:" + "\r\n";
                textBox1.Text += "Время:   " + spendtime.Milliseconds + " мс" + "\r\n";
                textBox1.Text += "Кол-во перестановок: " + swapping1.ToString() + "\r\n";
                textBox1.Text += "Кол-во сравнений: " + comprassion2.ToString() + "\r\n";
  
            }
            MasterPane masterPane = zedGraphControl1.MasterPane;
            MasterPane masterPane1 = zedGraphControl2.MasterPane;
            MasterPane masterPane2 = zedGraphControl3.MasterPane;
            
            masterPane.PaneList.Clear ();
            masterPane1.PaneList.Clear ();
            masterPane2.PaneList.Clear ();
            
            GraphPane pane = new GraphPane ();
            GraphPane pane1 = new GraphPane ();
            GraphPane pane2 = new GraphPane ();
            
            for (int i = 0; i < sizes.Count; i++)
            {
                DrawTimeSize(sizes[i], times1[i], times2[i], pane, list, list2, "Gnome", "Tim");
                DrawTimeSize(sizes[i], swapping_List[i], swapping2_List[i], pane1,  list3, list4, "Gnome", "Tim");
                DrawTimeSize(sizes[i], comprassion_List[i], comprassion2_List[i], pane2,  list5, list6, "Gnome", "Tim");
            }
            masterPane.Add (pane);
            masterPane1.Add (pane1);
            masterPane2.Add (pane2);
            
            zedGraphControl1.AxisChange ();
            zedGraphControl2.AxisChange ();
            zedGraphControl3.AxisChange ();
            
            zedGraphControl1.Invalidate ();
            zedGraphControl2.Invalidate ();
            zedGraphControl3.Invalidate ();
        }
        
        private void Cleaning()
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            swapping = 0;
            comprassion = 0; 
            swapping1 = 0;
            comprassion2 = 0;
            list.Clear(); list3.Clear(); list4.Clear(); list4.Clear(); list5.Clear(); list6.Clear();
            numb.Clear(); sizes.Clear(); times1.Clear(); times2.Clear(); swapping_List.Clear(); swapping2_List
                .Clear(); comprassion_List.Clear(); comprassion2_List.Clear();
            
        }
         public  void insertionSort(int[] arr,
                                int left, int right)
         {
             swapping++;
        for (int i = left + 1; i <= right; i++)
        {
            int temp = arr[i];
            int j = i - 1;
            while (j >= left && arr[j] > temp)
            {
                arr[j+1] = arr[j];
                j--;
            }
            arr[j+1] = temp;
        }
    }
       
    // merge function merges the sorted runs
    public  void merge(int[] arr, int l,
                                   int m, int r)
    {
        // original array is broken in two parts
        // left and right array
        comprassion+=7;
        int len1 = m - l + 1, len2 = r - m;
        int[] left = new int[len1];
        int[] right = new int[len2];
        for (int x = 0; x < len1; x++)
            left[x] = arr[l + x];
        for (int x = 0; x < len2; x++)
            right[x] = arr[m + 1 + x];
       
        int i = 0;
        int j = 0;
        int k = l;
       
        // After comparing, we merge those two array
        // in larger sub array
        while (i < len1 && j < len2)
        {
            if (left[i] <= right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }
       
        // Copy remaining elements
        // of left, if any
        while (i < len1)
        {
            arr[k] = left[i];
            k++;
            i++;
        }
       
        // Copy remaining element
        // of right, if any
        while (j < len2)
        {
            arr[k] = right[j];
            k++;
            j++;
        }
    }
       
    // Iterative Timsort function to sort the
    // array[0...n-1] (similar to merge sort)
    public List<int> timSort(int[] arr, int n)
    {
        comprassion+=3;
        // Sort individual subarrays of size RUN
        for (int i = 0; i < n; i+=RUN)
            insertionSort(arr, i,
                         Math.Min((i+RUN-1), (n-1)));
       
        // Start merging from size RUN (or 32).
        // It will merge
        // to form size 64, then
        // 128, 256 and so on ....
        for (int size = RUN; size < n;
                                 size = 2*size)
        {
             
            // Pick starting point of
            // left sub array. We
            // are going to merge
            // arr[left..left+size-1]
            // and arr[left+size, left+2*size-1]
            // After every merge, we increase
            // left by 2*size
            for (int left = 0; left < n;
                                  left += 2*size)
            {
                 
                // Find ending point of left sub array
                // mid+1 is starting point of
                // right sub array
                int mid = left + size - 1;
                int right = Math.Min((left +
                                    2*size - 1), (n-1));
       
                // Merge sub array arr[left.....mid] &
                // arr[mid+1....right]
                  if(mid < right)
                    merge(arr, left, mid, right);
            }
        }

        return arr.ToList();
    }
        public List<int> gnomeSort(int[] arr, int n)
        {
            int index = 0;
  
            while (index < n) 
            {
                comprassion2+=2;
                if (index == 0)
                    index++;
                if (arr[index] >= arr[index - 1])
                    index++;
                else
                {
                    comprassion2+=2;
                    swapping1++;
                    int temp = 0;
                    temp = arr[index];
                    arr[index] = arr[index - 1];
                    arr[index - 1] = temp;
                    index--;
                }
            }
            return arr.ToList();
        }
    }
}