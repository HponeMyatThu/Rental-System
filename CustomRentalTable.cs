using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_System
{
    class CustomRentalTable : RentalSystem_DataSetTableAdapters.RentTableAdapter
    {
        // Override the SelectAdmin() method
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, false)]
        public override RentalSystem_DataSet.RentDataTable SelectAdmin()
        {
            RentalSystem_DataSet.RentDataTable dataTable = new RentalSystem_DataSet.RentDataTable();

            // Your custom logic here...
            // For example, you can add a WHERE clause to the SELECT command or modify the data before returning it.

            // Call the base SelectAdmin() method to fill the dataTable using the original logic
            this.Adapter.SelectCommand = this.CommandCollection[6];
            try
            {
                this.Adapter.Fill(dataTable);
            }
            catch(Exception)
            {
                return dataTable;
            }
            

            return dataTable;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, false)]
        public override RentalSystem_DataSet.RentDataTable SortUserIDASC()
        {
            this.Adapter.SelectCommand = this.CommandCollection[8];
            RentalSystem_DataSet.RentDataTable dataTable = new RentalSystem_DataSet.RentDataTable();
            try
            {
                 this.Adapter.Fill(dataTable);
            }
            catch(Exception)
            {
                return dataTable;
            }

           
            return dataTable;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, false)]
        public override RentalSystem_DataSet.RentDataTable SortRentDateASC()
        {
            this.Adapter.SelectCommand = this.CommandCollection[7];
            RentalSystem_DataSet.RentDataTable dataTable = new RentalSystem_DataSet.RentDataTable();
            try
            {
                this.Adapter.Fill(dataTable);
            }
            catch(Exception)
            {
                return dataTable;
            }
            
            return dataTable;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, false)]
        public override RentalSystem_DataSet.RentDataTable SearchByUserID(string UserID)
        {
            this.Adapter.SelectCommand = this.CommandCollection[5];
            if ((UserID == null))
            {
                throw new global::System.ArgumentNullException("UserID");
            }
            else
            {
                this.Adapter.SelectCommand.Parameters[0].Value = ((string)(UserID));
            }
            RentalSystem_DataSet.RentDataTable dataTable = new RentalSystem_DataSet.RentDataTable();
            try
            {
                this.Adapter.Fill(dataTable);
            }
            catch(Exception)
            {
                 return dataTable;
            }
            
            return dataTable;
        }


        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, false)]
        public override RentalSystem_DataSet.RentDataTable SearchByRentID(string RentID)
        {
            this.Adapter.SelectCommand = this.CommandCollection[4];
            if ((RentID == null))
            {
                throw new global::System.ArgumentNullException("RentID");
            }
            else
            {
                this.Adapter.SelectCommand.Parameters[0].Value = ((string)(RentID));
            }
            RentalSystem_DataSet.RentDataTable dataTable = new RentalSystem_DataSet.RentDataTable();
            try
            {
                this.Adapter.Fill(dataTable);
            }
            catch(Exception)
            {
                return dataTable;
            }
            
            return dataTable;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, false)]
        public override RentalSystem_DataSet.RentDataTable SearchByApplianceID(string ApplianceID)
        {
            this.Adapter.SelectCommand = this.CommandCollection[2];
            if ((ApplianceID == null))
            {
                throw new global::System.ArgumentNullException("ApplianceID");
            }
            else
            {
                this.Adapter.SelectCommand.Parameters[0].Value = ((string)(ApplianceID));
            }
            RentalSystem_DataSet.RentDataTable dataTable = new RentalSystem_DataSet.RentDataTable();
            try
            {
                this.Adapter.Fill(dataTable);
            }
            catch (Exception)
            {
                return dataTable;
            }
           
            return dataTable;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        [global::System.ComponentModel.DataObjectMethodAttribute(global::System.ComponentModel.DataObjectMethodType.Select, false)]
        public override RentalSystem_DataSet.RentDataTable SearchByRentDate(string From)
        {
            this.Adapter.SelectCommand = this.CommandCollection[3];
            if ((From == null))
            {
                throw new global::System.ArgumentNullException("From");
            }
            else
            {
                this.Adapter.SelectCommand.Parameters[0].Value = ((string)(From));
            }
            
            RentalSystem_DataSet.RentDataTable dataTable = new RentalSystem_DataSet.RentDataTable();
            try
            {
                this.Adapter.Fill(dataTable);
            }
            catch (Exception)
            {
                return dataTable;
            }
           
            return dataTable;
        }


    }
}
