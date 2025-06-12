namespace KMNShop.Catalog.Dtos.CategoryDtos
{
    public class CreateCategoryDto
    {
        public string Name { get; set; }

        public string? ParentCategoryID { get; set; }

        public bool IsSelectable { get; set; }
    }
}
