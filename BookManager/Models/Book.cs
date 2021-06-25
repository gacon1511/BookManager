namespace BookManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        [StringLength(255)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Nội dung không được để trống")]
        [StringLength(255)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Tác giả không được để trống")]
        [StringLength(255)]
        public string Author { get; set; }

        [Required]
        [StringLength(255)]
        public string Images { get; set; }
        [Required]
        [Range(1000,1000000, ErrorMessage = "Giá tiền nằm trong khoảng 1k đến 1m")]
        public int Price { get; set; }
    }
}
