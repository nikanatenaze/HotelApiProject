using HotelAPIProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelAPIProject.Data.Config
{
    public class RoomConfig : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Rooms");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.Property(x => x.Stars).IsRequired(true).HasMaxLength(5);
            builder.Property(x => x.Price).IsRequired(true).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Description).HasMaxLength(50);

            builder.HasOne(h => h.Hotel)
                .WithMany(r => r.Rooms)
                .HasForeignKey(r => r.HotelId);
        }
    }
}
