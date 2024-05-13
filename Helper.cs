using System.Collections.Generic;
using System.Windows.Forms;

public class Helper
{
    public static void PrikaziListuUListBoxu<NekiTip>(List<NekiTip> lista, ListBox listBox)
    {
        listBox.Items.Clear();
        lista.Sort();
        foreach(NekiTip element in lista)
        {
            listBox.Items.Add(element);
        }
    }
}