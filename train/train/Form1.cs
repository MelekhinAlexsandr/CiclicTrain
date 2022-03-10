namespace train
{
    public partial class Form1 : Form
    {
        List<Vagon> list = new List<Vagon>();
        List<Vagon> listNew = new List<Vagon>();
        Vagon v = new Vagon();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrainText.Text = "";
            list.Clear();
            listNew.Clear();
            trainText2.Text = "";

            Random n = new Random();
            int count = n.Next(10, 16)-1;
            countVagon.Text = count.ToString();
            bool light = false;

            for (int i=0; i<count; i++)
            {
                v = new Vagon();

                light = rndBool(light);
                v.number= i;
                v.light = light;

                list.Add(v);
                TrainText.Text += string.Format("|__{0}__{1}__|+",v.number+1,v.light);
            }
            v = new Vagon();

            v.number = 0;
            v.light = list[0].light;
            list.Add(v);
            TrainText.Text += string.Format("|__{0}__{1}__|+", list.Last().number+1, list.Last().light);

            countWagon.Text = countRailCar().ToString();

            foreach (Vagon v in listNew)
            {
                if (v.number == listNew.Count - 1)
                {
                    trainText2.Text += string.Format("|__{0}__{1}__|+", 1, v.light);
                }
                else
                {
                    trainText2.Text += string.Format("|__{0}__{1}__|+", v.number + 1, v.light);
                }
            }
        }
        public bool rndBool(bool light)
        {
            Random lightInt = new Random();
            switch (lightInt.Next(0, 2))
            {
                case 0:
                    light = false;
                    break;
                case 1:
                    light = true;
                    break;
            }
            return light;
        }
        public int countRailCar()
        {
            int i = 0;
            if (list[0].light == false && list[0].number == 0)
            {
                v = new Vagon();

                v.number = 0;
                v.light = true;

                list[list.Count-1].number = 0;
                list[list.Count-1].light = true;

                listNew.Add(v);  
            }
            else
            {
                v = new Vagon();

                v.number = 0;
                v.light = true;

                listNew.Add(v);
            }
            i++;
            while (true)
            {
                if (list[i].light == true)
                {
                    v = new Vagon();

                    v.number = i;
                    v.light = false;

                    listNew.Add(v);

                    if (i == list.Count - 1)
                    {
                        listNew[0].light = false;
                    }

                    if (listNew[(listNew.Count-1)-(listNew.Count-1)].light == false)
                    {
                        break;
                    }
                    
                }
                else
                {
                    v = new Vagon();

                    v.number = i;
                    v.light = false;

                    listNew.Add(v);
                }
                i++;
            }
            return i;
        }
    }
}