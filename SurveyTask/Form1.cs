namespace SurveyTask
{
    public partial class Form1 : Form
    {
        Database database = new Database();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //database.AddPerson(new Person("kenan", "nuri", "azerbaijan", "sabirabad", new DateTime(2005, 11, 21), "kenan@gmail.com", true, "male"));
            //database.AddPerson(new Person("ismayil", "rehimov", "azerbaijan", "baku", new DateTime(2005, 10, 12), "ismayil@gmail.com", false, "male"));
            //database.AddPerson(new Person("Nigar", "Memmedli", "Azerbaijan", "Baku", new DateTime(2004, 9, 12), "nigar@gmail.com", false, "Female"));
            foreach (var item in database.GetPerson())
                comboBox1.Items.Add(item.Name);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var target = database.GetPerson().FirstOrDefault(p => p.Name == comboBox1.SelectedItem.ToString());

            name.Text = target.Name;
            surname.Text = target.Surname;
            country.Text = target.Country;
            city.Text = target.City;
            email.Text = target.Email;
            email.Enabled = false;
            pic1.Value = target.Datetime;
            if (target.MilitaryStatus)
            {

                checkBox3.Enabled = false;
                checkBox3.Checked = true;
                checkBox4.Enabled = false;
                checkBox4.Checked = false;
            }
            else
            {
                checkBox4.Enabled = false;
                checkBox3.Enabled = false;
                checkBox3.Checked = false;
                checkBox4.Checked = true;

            }
            if (target.Gender == "Male")
            {
                checkBox1.Checked = true;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox2.Checked = false;
            }
            else
            {
                checkBox1.Enabled = false;
                checkBox1.Checked = false;
                checkBox2.Checked = true;
                checkBox2.Enabled = false;
            }


        }
        public void ComboboxRefresh()
        {
            comboBox1.Items.Remove(comboBox1.Text);
            comboBox1.Items.Add(name.Text);
            comboBox1.Text = name.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person(
                name.Text,
                surname.Text,
                country.Text,
                city.Text,
                new DateTime(pic1.Value.Year, pic1.Value.Month, pic1.Value.Day),
                email.Text,
                checkBox3.Checked ? true : false,
                checkBox1.Checked ? "Male" : "Female"); 

            var target = database.GetPerson().Any(t => t.Email ==  email.Text);
            var result = database.GetPerson().FirstOrDefault(person => person.Email == email.Text);
            if (target)
            {
                database.GetPerson().Remove(result);
                database.AddPerson(newPerson);
                ComboboxRefresh();
                Refresh();
                return;
            }
            database.AddPerson(newPerson);
            ComboboxRefresh();


        }
    }
}