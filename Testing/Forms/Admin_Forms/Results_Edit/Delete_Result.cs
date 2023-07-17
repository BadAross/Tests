using Testing.Classes;

namespace Testing.Forms.Admin_Forms.Results_Edit
{
    public static class Delete_Result
    {
        public static void Delete_Select_Result(int id_Result)
        {
            DataBase_Editor.Edited_Information_To_DataBase(@"delete
                from Results
                where Id_Result = " + id_Result + "");
        }
    }
}
