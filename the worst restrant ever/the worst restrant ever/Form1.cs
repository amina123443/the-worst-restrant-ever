namespace the_worst_restrant_ever
{
    public partial class Form1 : Form
    {
        struct UserOrder
        {
            public Label label;
            public float price;
            public string? FoodSize;
        }
        int counter = 1;//how many order is there (+1)
        int codAndchips = 0;
        string size = "small";// the starting size
        float total = 0.00F;
        List<UserOrder> ListOfOrders = new();

        List<string> orderedfood = new();//this has to be a sepreate list since errors have been caused trying to add the food into user order
        string[] foods = { "chips", "tea", "coffee", "water", "chicken nuggets", "salad", "cod", "donna chicken", "beef", "horse" };//menu
        float[] foodsPrice = { 2.00F, 2.00F, 0.50F, 1.00F, 3.00F, 1.00F, 5.50F, 3.00F, 20.46F, 49.99F };//menu price
        //they are seperated since a triplets will have an extreamly long line of code which I don't want to bother with
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowMenu(object sender, MouseEventArgs e)
        {
            Form2 form2 = new();
            form2.Show();
        }//presents the menu


        private Label addinglable(string text)
        {
            Label newlable = new();
            newlable.Name = counter.ToString();
            newlable.Text = text;
            newlable.AutoSize = true;
            newlable.Size = new Size(38, 15);
            newlable.Location = new Point(label1.Location.X, label1.Location.Y + (counter * 30));
            newlable.Visible = true;
            return newlable;

        }//adds a new lable dyamicly

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void new_order(object sender, MouseEventArgs e)//verifyes the order is valid by following the rules
        {
            string order = textBox1.Text.ToLower();//the text box is set to be lower to prevent the system being cap sentetive which is annoying
            if (counter != 6)
            {

                bool failed = false;
                if (orderedfood.Count > 0)//skip if this is the first time the user is ordering
                {
                    foreach (string food in orderedfood)
                    {
                        if (order == food)//if they try to order the same thing
                        {
                            failed = true;
                            MessageBox.Show("you already have this as an order, try a diffrent one");
                            break;
                        }
                    }
                }

                if (!failed)
                {
                    failed = true;

                    foreach (string food in foods)
                    {
                        if ((order == food))//if the order is in the menu
                        {

                            failed = false;
                            addingorder(order);//add the order
                            break;

                        }
                    }
                    if (failed) { MessageBox.Show("check your spelling because we couldn't find your order in our menu"); }
                }
            }//checks if there is space for another order
            else
            {
                MessageBox.Show("you already have 5 order");
            }

        }
        private void addingorder(string UserOrder)
        {
            UserOrder order = new();//to make recording price and size easier

            orderedfood.Add(UserOrder);
            order.price = foodsPrice[Array.IndexOf(foods, UserOrder)];
            float extra = 0F;
            if (UserOrder == "chips" || UserOrder == "chicken nugget")//apply the sizes cost
            {
                order.FoodSize = size;
                if (size == "small" && UserOrder == "chips")
                {
                    extra = -0.50F;
                }
                else if (size == "large")
                {
                    extra = 1.00F;
                }
            }
            else
            {
                order.FoodSize = null;
            }
            string Text = (order.FoodSize + " " + UserOrder + ": £" + Convert.ToString(order.price + extra));


            Label lable = addinglable(Text);//adds the lable for the person to see
            Controls.Add(lable);
            order.label = lable;
            ListOfOrders.Add(order);
            button2.Enabled = true;//lets the user end the ordering
            total += (order.price + extra);
            if (UserOrder == "cod")//checks if the person orded cod and a large chips
            {
                codAndchips += 1;// if found, increase this counter by one
            }
            else if (order.FoodSize == "large" && UserOrder == "chips")
            {
                codAndchips += 1;
            }

            if (codAndchips == 2)//once both item has been found apply the discount 
            {
                total -= 1.5F;
            }
            label4.Text = "total price: £" + Convert.ToString(total);//display the total
            counter++;
        }//cerate the new order


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { size = "small"; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { size = "medium"; }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) { size = "large"; }
        }

        private void end_ordering(object sender, MouseEventArgs e)//closes the form
        {
            MessageBox.Show("we will arive to your table with your food have a great day");
            this.Close();


        }

    }
}