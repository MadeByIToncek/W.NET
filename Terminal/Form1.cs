using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using System.Reflection;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Cfg;

namespace Terminal
{
    public partial class Form1 : Form
    {
        ISessionFactory _factory = CreateSessionFactory();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form_Load;
        }
        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
              .Database(MySQLConfiguration.Standard
                .ConnectionString(c => c
                    .Server("localhost")
                    .Database("walnet")
                    .Username("root")
                    .Password("root")))
              .Mappings(x => x.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
              .ExposeConfiguration(TreatConfiguration)
              .BuildSessionFactory();
        }

        private static void TreatConfiguration(Configuration configuration)
        {
            var update = new SchemaUpdate(configuration);
            update.Execute(false, true);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            var rowCount = 5;
            var columnCount = 5;

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

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {

                    var button = new Button();
                    button.Text = string.Format("{0}{1}", i, j);
                    button.Name = string.Format("button_{0}{1}", i, j);
                    button.Dock = DockStyle.Fill;
                    tableLayoutPanel1.Controls.Add(button, j, i);
                }
            }
        }
    }
}
