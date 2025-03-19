using HotelAPIProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelAPIProject.Data.Config
{
    public class BookingConfig : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable("Bookings");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn(1, 1);
            builder.Property(x => x.TotalPrice).IsRequired(true);
            builder.Property(x => x.BookingStarts).IsRequired(true).HasMaxLength(50);
            builder.Property(x => x.BookingEnds).IsRequired(true).HasMaxLength(50);
            builder.Property(x => x.RoomId).IsRequired(true);
        }
    }
}
