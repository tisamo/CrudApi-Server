namespace CrudApi.Controllers.Models
{
    public class TreeListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }
        public string Climate { get; set; }

        public static TreeListItem From(TreeModel tree)
        {
            return new TreeListItem
            {
                Id = tree.Id,
                Name = tree.Name,
                Image = tree.Image,
                Age = tree.Age,
                Climate = tree.Climate
              

                
            };
        }
    }
}