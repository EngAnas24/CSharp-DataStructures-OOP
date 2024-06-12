namespace DropdownListTest.Data
{
    public interface IDatahelper<Table>
    {
        List<Table> GetTables();
        Table Find(int id);
        public void Add(Table table);
        public void Remove(int id);

        public void Update(int id,Table table);
    }
}
