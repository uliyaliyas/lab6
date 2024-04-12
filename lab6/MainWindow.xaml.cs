using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> listLab1;
        private Queue<int> queue;
        private LinkedList<int> listLab3;
        public MainWindow()
        {
            InitializeComponent();
            listLab1 = new List<int>();
            queue = new Queue<int>();
            listLab3 = new LinkedList<int>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listLab1.Add(int.Parse(tbElement.Text));
            lbList.ItemsSource = null;
            lbList.ItemsSource = listLab1;
            tbElement.Text = "";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int index = lbList.SelectedIndex;
            listLab1.RemoveAt(index);
            lbList.ItemsSource = null;
            lbList.ItemsSource = listLab1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int count = 0;
            foreach(int l in listLab1)
            {
                if (l < 0) count++;
            }
            Result.Text = "Индекс:" + count.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            queue.Enqueue(int.Parse(tbElementQue.Text));
            lbQue.ItemsSource = null;
            lbQue.ItemsSource = queue;
            tbElementQue.Text = "";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(tbCount.Text);
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += queue.Dequeue() + " ";
            }
            ResultQue.Text = result;
            lbQue.ItemsSource = null;
            lbQue.ItemsSource = queue;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            listLab3.Add(int.Parse(tbElementList.Text));
            lbList3.Items.Clear();
            foreach (int item in listLab3)
            {
                lbList3.Items.Add(item);
            }
            tbElementList.Text = "";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            listLab3.Clear();
            lbList3.Items.Clear();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            int i = 0;
            foreach (var index in listLab3)
            {
                if (index < 2) listLab3.Insert(i + 1, 15);
                i++;
            }
            lbList3.Items.Clear();
            foreach (int item in listLab3)
            {
                lbList3.Items.Add(item);
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            List<Bone> list = new List<Bone>();
            for (int i = 1; i <= 1000; i++)
            {
                list.Add(new Bone(i));
            }
            Ishod.ItemsSource = list;
            Dictionary<int, Probably> results = new Dictionary<int, Probably>();
            double count2, count3, count4, count5, count6, count7, count8, count9, count10, count11, count12;
            count2 = count3 = count4 = count5 = count6 = count7 = count8 = count9 = count10 = count11 = count12 = 0;
            foreach (Bone item in list)
            {
                switch(item.Summa)
                {
                    case 2: count2++; break;
                    case 3: count3++; break;
                    case 4: count4++; break;
                    case 5: count5++; break;
                    case 6: count6++; break;
                    case 7: count7++; break;
                    case 8: count8++; break;
                    case 9: count9++; break;
                    case 10: count10++; break;
                    case 11: count11++; break;
                    case 12: count12++; break;
                }
            }
            Random random = new Random();
            results.Add(2, new Probably { Prob = count2 / 1000, Teor = random.NextDouble() * 20 });
            results.Add(3, new Probably { Prob = count3 / 1000, Teor = random.NextDouble() * 20 });
            results.Add(4, new Probably { Prob = count4 / 1000, Teor = random.NextDouble() * 20 });
            results.Add(5, new Probably { Prob = count5 / 1000, Teor = random.NextDouble() * 20 });
            results.Add(6, new Probably { Prob = count6 / 1000, Teor = random.NextDouble() * 20 });
            results.Add(7, new Probably { Prob = count7 / 1000, Teor = random.NextDouble() * 20 });
            results.Add(8, new Probably { Prob = count8 / 1000, Teor = random.NextDouble() * 20 });
            results.Add(9, new Probably { Prob = count9 / 1000, Teor = random.NextDouble() * 20 });
            results.Add(10, new Probably { Prob = count10 / 1000, Teor = random.NextDouble() * 20 });
            results.Add(11, new Probably { Prob = count11 / 1000, Teor = random.NextDouble() * 20 });
            results.Add(12, new Probably { Prob = count12 / 1000, Teor = random.NextDouble() * 20 });
            List<resultBone> resBone = new List<resultBone>();
            foreach (var res in results)
            {
                resBone.Add(new resultBone { Key = res.Key, Prob = Math.Round(res.Value.Prob * 100, 2), Pred = Math.Round(res.Value.Teor, 2) });
            }
            Results.ItemsSource = resBone;
        }
    }
}