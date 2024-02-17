using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using System.Reflection;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Cfg;
using Terminal.Entities;

namespace Terminal
{
    public partial class Form1 : Form
    {
        private readonly ISessionFactory _factory = Fluently.Configure()
              .Database(MySQLConfiguration.Standard
                .ConnectionString(c => c
                    .Server("localhost")
                    .Database("walnet")
                    .Username("root")
                    .Password("root")))
              .Mappings(x => x.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
              .ExposeConfiguration(TreatConfiguration)
              .BuildSessionFactory();

        public Form1()
        {
            InitializeComponent();
            Load += Form_Load;
        }

        private static void TreatConfiguration(Configuration configuration)
        {
            SchemaUpdate update = new SchemaUpdate(configuration);
            update.Execute(false, true);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            int rowCount = 5;
            int columnCount = 5;

            tableLayoutPanel1.ColumnCount = columnCount;
            tableLayoutPanel1.RowCount = rowCount;

            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            for (int i = 0; i < columnCount; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columnCount));
            }
            for (int i = 0; i < rowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rowCount));
            }

            IList<FoodType> list = ListFood();
            int currentIndex = 0;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (currentIndex++ < list.Count)
                    {
                        FoodType type = list.ElementAt(currentIndex-1);
                        Button button = new()
                        {
                            Text = type.Name + "\n" + type.Price + " kè",
                            Name = "addToCart_"+type.Id,
                            Dock = DockStyle.Fill,
                            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238)
                    };
                        tableLayoutPanel1.Controls.Add(button, j, i);
                    }
                }
            }
        }

        public IList<FoodType> ListFood()
        {
            using ISession session = _factory.OpenSession();
            using (session.BeginTransaction())
            {
                return session.CreateCriteria(typeof(FoodType))
                  .List<FoodType>();
            }
        }
    }
}
