using Testing.Classes;

namespace Testing.Forms.Admin_Forms.Tests_Edit
{
    public class Delete_Test
    {
        public static void Delete_Select_Test(int id_Test)
        {
            DataBase_Editor.Edited_Information_To_DataBase(@"delete
                from Qustions 
                where Test_Id = " + id_Test + @"; 
                delete
                from Results
                where Test_Id = " + id_Test + @";
                delete
                from Tests
                where Id_Test = " + id_Test + "");
        }
    }
}
