
/// <summary>
/// Will set the type of command that is to be executed in the data base.
/// </summary>
namespace Sistema_Control_Estudiantil.Resources
{
    public enum TypeOfCommand
    {
        /// <summary>
        /// Uses a normal Select * From command to bring tables to the database.
        /// </summary>
        SelectCommand  = 1,

        /// <summary>
        /// Specifies the Execute Procedure that is to use in the databse.
        /// </summary>
        SelectProcedure = 2,

        /// <summary>
        /// Specifies that the execute procedure in the database takes more then one value.
        /// </summary>
        SelectProcedureValues = 3
    }
}
