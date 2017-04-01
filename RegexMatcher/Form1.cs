using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Web;

namespace RegexMatcher {

	public partial class Form1 : Form {
		List<string> FilteredLines = new List<string>();

		public Form1() {
			InitializeComponent();
			FilteredLines = new List<string>();
			cmdUnfilter.Enabled = false;
			
		}

		private void GetMatches() {
			GetMatches(true);
		}

		private void GetMatches(bool resetSliders) {
			if (tbRegex.Text.Length > 0) {
				try {
					Regex r = new Regex(tbRegex.Text, RegexOptions.Multiline | RegexOptions.Compiled);
					if (cbCaseInsensitive.Checked) {
						r = new Regex(tbRegex.Text, RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.Compiled);
					}
					DateTime now = DateTime.Now;
					if (r.IsMatch(richTextBox1.Text)) {
						richTextBox1.SelectAll();
						richTextBox1.SelectionBackColor = Color.White;
						richTextBox1.DeselectAll();
						MatchCollection mc = r.Matches(richTextBox1.Text);
						tbRegex.BackColor = Color.Lime;
						lblMatches.Text = "1 / " + mc.Count;

						if (resetSliders) {
							tbGroups.Enabled = true;
							tbGroups.Maximum = mc[0].Groups.Count - 1;
							tbGroups.Value = 0;
						}
						lblGroups.Text = "1 / " + mc[0].Groups.Count;

						lblGroupName.Text = r.GroupNameFromNumber(tbGroups.Value);
						foreach (Match m in mc) {
							//foreach (int index in GetAllIndexes(richTextBox1.Text, m.Groups[tbGroups.Value].Value)) {
							//    richTextBox1.Select(index, m.Groups[tbGroups.Value].Value.Length);
							//    richTextBox1.SelectionBackColor = Color.Green;
							//}
							richTextBox1.Select(m.Groups[tbGroups.Value].Index, m.Groups[tbGroups.Value].Length);
							richTextBox1.SelectionBackColor = Color.Lime;
						}
					}
					else {
						tbRegex.BackColor = Color.Red;

						tbGroups.Maximum = 0;
						tbGroups.Enabled = false;

						lblMatches.Text = "- / -";
						lblGroups.Text = "- / -";
					}
					TimeSpan executionTime = DateTime.Now - now;
					lblTime.Text = executionTime.Seconds.ToString() + "." + executionTime.Milliseconds.ToString("000");
				}
				catch (System.ArgumentException) {
					tbRegex.BackColor = Color.Yellow;
				}
			}
		}


		private void tbGroups_Scroll(object sender, EventArgs e) {
			if (cbLiveUpdate.Checked) {
				GetMatches(false);
			}
		}

		//private int[] GetAllIndexes(string FullString, string SubString) {
		//    List<int> indexes = new List<int>();

		//    for (int i = 0; i < FullString.Length - SubString.Length; ++i ) {
		//        int foundIndex = FullString.IndexOf(SubString, i);
		//        if (foundIndex != -1) {
		//            if (indexes.Count > 0) {
		//                if (indexes[indexes.Count - 1] != foundIndex) {
		//                    indexes.Add(foundIndex);
		//                }
		//            }
		//            else {
		//                indexes.Add(foundIndex);
		//            }
		//        }
		//    }
		//    return indexes.ToArray();
		//}


		private void cmdUpdateNow_Click(object sender, EventArgs e) {
			GetMatches();
		}

		private void cbLiveUpdate_CheckedChanged(object sender, EventArgs e) {
			GetMatches();
		}

		private void cbCaseInsensitive_CheckedChanged(object sender, EventArgs e) {
			GetMatches();
		}

		private void cmdFilter_Click(object sender, EventArgs e) {
			FilteredLines.Add(richTextBox1.Text);
			//only add matched lines
			Regex r = new Regex(tbRegex.Text, RegexOptions.Multiline);
			List<string> lines = new List<string>();
			if (cbCaseInsensitive.Checked) {
				r = new Regex(tbRegex.Text, RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Singleline);
			}
			if (r.IsMatch(richTextBox1.Text)) {
				MatchCollection mc = r.Matches(richTextBox1.Text);
				foreach (Match m in mc) {
					lines.Add(m.Groups[tbGroups.Value].Value);
				}
			}
			richTextBox1.Text = string.Empty;
			foreach (string line in lines) {
				richTextBox1.Text += line + System.Environment.NewLine;
			}
			cmdUnfilter.Enabled = true;
			cmdUnfilter.Text = string.Format("Unfilter ({0})", FilteredLines.Count.ToString());
			GetMatches();
		}

		private void cmdUnfilter_Click(object sender, EventArgs e) {
			richTextBox1.Text = FilteredLines[FilteredLines.Count - 1];
			FilteredLines.RemoveAt(FilteredLines.Count - 1);
			if (FilteredLines.Count == 0) {
				cmdUnfilter.Enabled = false;
			}
			cmdUnfilter.Text = string.Format("Unfilter ({0})", FilteredLines.Count.ToString());
			GetMatches();
		}


		private void tbEncodedRegex_TextChanged(object sender, EventArgs e) {
			string decodedText = HttpUtility.HtmlDecode(tbEncodedRegex.Text);
			tbRegex.Text = decodedText;
		}

		private void tbRegex_TextChanged(object sender, EventArgs e) {
			tbEncodedRegex.Text = HttpUtility.HtmlEncode(tbRegex.Text);
			if (cbLiveUpdate.Checked) {
				if (tbRegex.Text.Length > 0) {
					GetMatches();
				}
				else {
					richTextBox1.Select(0, richTextBox1.Text.Length);
					richTextBox1.SelectionBackColor = Color.White;
					richTextBox1.DeselectAll();
				}
			}
		}

	}
}