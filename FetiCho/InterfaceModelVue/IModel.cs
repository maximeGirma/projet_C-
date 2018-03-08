using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceModelView;

namespace InterfaceModelView
{
    public interface IModel
    {
        DataList GetStoredDataByDate(DateTime date);

        Boolean ImportDataFromTxt();

        RecipientList ImportRecipientList();

        Boolean AddRecipient(String email,String name);

        Boolean DeleteRecipient(int id_recipient);

        Boolean ExportToPdf(String email, DataList datalist);

        Boolean ExportToCsv(DataList datalist);
    }
}
