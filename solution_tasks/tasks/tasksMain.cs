using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tasks
{
	public partial class frmMain : Form
	{
		private List<string> tarefas;

		public frmMain()
		{
			InitializeComponent();
			tarefas = new List<string>();
		}

		private void btnAdcTarefa_Click(object sender, EventArgs e)
		{
			string tarefa = txtTarefa.Text.Trim();
			DateTime data = dateTarefa.Value;

			if (!string.IsNullOrEmpty(tarefa))
			{
				Tarefa novaTarefa = new Tarefa(tarefa, data);
				tarefas.Add(Convert.ToString(tarefa));
				chkTarefas.Items.Add(novaTarefa);
				txtTarefa.Clear();
			}

		}

		public class Tarefa
		{
			public string Nome { get; set; }
			public DateTime Data { get; set; }

			public Tarefa(string nome, DateTime data)
			{
				Nome = nome;
				Data = data;
			}

			public override string ToString()
			{
				return $"{Nome} - {Data.ToShortDateString()}";
			}
		}
	}
}
