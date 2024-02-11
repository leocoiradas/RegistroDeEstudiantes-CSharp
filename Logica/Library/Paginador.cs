using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class Paginador<T>
    {
        private List<T> _dataList;
        private Label _label;
        private static int maxReg, _reg_for_page, pageCount, numPage = 1;
        public Paginador(List<T> dataList, Label label, int reg_for_page)
        {
            _dataList = dataList;
            _label = label;
            _reg_for_page = reg_for_page;
            LoadData();

        }
        private void LoadData()
        {
            numPage = 1;
            maxReg = _dataList.Count;
            pageCount = (maxReg/_reg_for_page);
            //A continuación verificamos si el resto de la operación da mayor a 1
            //En ese caso, creamos una nueva página con los elementos restantes
            if((maxReg / _reg_for_page) > 0)
            {
                pageCount += 1;

            }
            _label.Text = $"Paginas 1/{pageCount}";
        }
        public int First()
        {
            numPage = 1;
           _label.Text = $"Paginas 1/{pageCount}";
            return numPage;
        }
        public int Next()
        {
            if (numPage < pageCount)
            {
                numPage++;
                _label.Text = $"Paginas {numPage} / {pageCount}";
                

            }
            else
            {
                First();
            }
            return numPage;
        }
        public int Previous()
        {
            if (numPage > 1)
            {
                numPage--;
                _label.Text = $"Paginas {numPage} / {pageCount}";
            }
            else
            {
                Last();
            }
            return numPage;
        }
        public int Last()
        {
            numPage = pageCount;
            _label.Text = $"Paginas {numPage} / {pageCount}";
            return numPage;
        }
    }
}
