﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace searchDormWeb.Areas.Admin.Models.Reservation
{
    public class ReservationsVm
    {
        [Display(Name = "Start date",
        Description = "The start date of the search."),
        DataType(DataType.Date),
        MaxLength(256)]
        public DateTime StartDate { get; set; }


        [Display(Name = "End date",
        Description = "The end date of the search."),
        DataType(DataType.Date),
        MaxLength(256)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Room",
        Description = "Search by a specific room."),
        DataType(DataType.Text),
        MaxLength(256)]
        public string Room { get; set; }

        [Display(Name = "Booking status",
        Description = "Search by a specific booking status e.g. Pending.")]
        public IEnumerable<int> BookingStatus { get; set; }

        [Display(Name = "Payment status",
        Description = "Search by a specific payment status e.g. Paid.")]
        public IEnumerable<int> PaymentStatus { get; set; }


        [EmailAddress,
        Display(Name = "Billing email address",
        Description = "Filter by customer biling email address."),
        DataType(DataType.EmailAddress),
        MaxLength(256)]
        public string BillingEmailAddress { get; set; }

        [Display(Name = "Billing last name",
        Description = "Filter by customer billing last name."),
        DataType(DataType.Text),
        MaxLength(256)]
        public string BillingLastName { get; set; }

        [Display(Name = "Billing country",
        Description = "Filter by booking biling country."),
        MaxLength(256)]
        public int BillingCountry { get; set; }

        [Display(Name = "Payment method",
        Description = "Search by a specific payment method."),
        MaxLength(256)]
        public int PaymentMethod { get; set; }

        [Display(Name = "Booking notes",
        Description = "Search in order notes. Leave empty to load all bookings."),
        DataType(DataType.Text),
        MaxLength(256)]
        public string BookingNotes { get; set; }

        [Display(Name = "Go directly to booking #",
        Description = "Go directly to booking number #."),
        MaxLength(256)]
        public int GoDirectlyToBookingNumber { get; set; }

    }

    public class ReservationEdit
    {
        [Display(Name = "Booking Status",
        Description = "The status of the booking"), DataType(DataType.Text), MaxLength(256)]
        public string BookingStatus { get; set; }

        [Display(Name = "Booking Order Number",
        Description = "The unique number of this booking order."), DataType(DataType.Text), MaxLength(256)]
        public string BookingOrderNumber { get; set; }

        [Display(Name = "Dormitory",
        Description = "A dormitory name in which this booking order was placed."), DataType(DataType.Text), MaxLength(256)]
        public string Dormitory { get; set; }



        [Display(Name = "Customer",
        Description = "The customer who placed this booking order."), DataType(DataType.Text), MaxLength(256)]
        public string Customer { get; set; }

        [Display(Name = "Customer Ip Address",
        Description = "Customer IP address"), DataType(DataType.Text), MaxLength(256)]
        public string CustomerIpAddress { get; set; }

        [Display(Name = "Booking Order Subtotal",
        Description = "The subtotal of this booking order."), DataType(DataType.Text), MaxLength(256)]
        public string BookingOrderSubtotal { get; set; }

        [Display(Name = "Booking Fee",
        Description = "The total shipping cost for this booking order."), DataType(DataType.Text), MaxLength(256)]
        public string BookingFee { get; set; }

        [Display(Name = "Order Total",
        Description = "The total cost of this booking order(includes discounts, booking fee & tax)."), DataType(DataType.Text), MaxLength(256)]
        public string OrderTotal { get; set; }

        [Display(Name = "Profit",
        Description = "Profit of this order."), DataType(DataType.Text), MaxLength(256)]
        public string Profit { get; set; }

        [Display(Name = "Payment Method",
        Description = "The payment method used for this transaction.You can manage Payment Methods from Configuration : Payment : Payment Methods."), DataType(DataType.Text), MaxLength(256)]
        public string PaymentMethod { get; set; }


        [Display(Name = "Payment Status",
        Description = "The status of the payment."), DataType(DataType.Text), MaxLength(256)]
        public string PaymentStatus { get; set; }

        [Display(Name = "Created On",
        Description = "The date/time the booking order was placed/created."), DataType(DataType.Text), MaxLength(256)]
        public string CreatedOn { get; set; }


        [Display(Name = "Billing Address",
    Description = "The billing address of customer"), DataType(DataType.Text), MaxLength(256)]
        public string BillingAddress { get; set; }


        public OrderNotesTab orderNotesTab { get; set; }
    }


    public class BillingAddressTable
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string ZipPostalCode { get; set; }
        public string Country { get; set; }

    }

    public class RoomResevationTable{
public string Picture { get; set; }
public string RoomName {get; set;}
public string Price {get; set;}
public string Quantity {get; set;}
public string Discount {get; set;}
public string Total {get; set;}
public string Edit {get; set;}

    }

    public class OrderNotesTable
    {
public string CreatedOn {get; set;}
public string Note {get; set;}
public string AttachedFile {get; set;}
public string DisplayToCustomer {get; set;}
public string Delete { get; set; }

    }


    public class OrderNotesTab
    {
        [Display(Name = "Note",
        Description = "A note about booking."), DataType(DataType.Text), MaxLength(256)]
        public string Note { get; set; }

        [Display(Name = "Attached file",
      Description = "Attached file to this to the order note, e.g booking receipt an so on.")]
        public bool AttachedFile { get; set; }


        [Display(Name = "Display to customer",
      Description = "Check this option to display this booking note to customer")]
        public bool DisplayToCustomer { get; set; }

    }

}
