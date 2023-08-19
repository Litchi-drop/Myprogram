using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Core5._0
{
    class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("T_Books");
            //设置book表title字段最大长度为20并且不可为空
            builder.Property(b => b.Title).HasMaxLength(50).IsRequired();
            builder.Property(b => b.AuthorName).HasMaxLength(20).IsRequired();
        }
    }
}
