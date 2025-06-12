namespace KMNShop.Catalog.Dtos.CategoryDtos
{
    public class GeyByIdCategoryDto
    {
        public string CategoryID { get; set; }

        public string Name { get; set; }

        public string? ParentCategoryID { get; set; }

        public bool IsSelectable { get; set; }
    }
}
