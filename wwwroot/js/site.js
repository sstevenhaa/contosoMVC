// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

      $(function () {
        $.getJSON("/data/data.json", function (data) {
          $.each(data.sessions, function (i, f) {
            var tblRow =
              "<tr>" +
              "<td>" +
              f.speaker +
              "</td>" +
              "<td>" +
              f.subject +
              "</td>" +
              "<td>" +
              f.date +
                "</td>" +
                 "<td><button type='button' id='" + f.btn + "' onclick='reserveSeat()'>" +
                  "Reserve Seat</button> <p id='" + f.speaker + "'>" + f.seats + "</p></td>" + 
                "<td><a href='" + f.details + "' target='_blank'/>see details</td>" +
              "</tr>" ;
            $(tblRow).appendTo("#userdata tbody");
          });
        });
      }); 

//function reserveSeat() {
//    // this doesn't work

//    $.getJSON("/data/data.json", function (data) {
//        $.each(data.sessions, function (i, f) {
//            if (seats == 0) {
//                document.getElementById(f.speaker).innerHTML = f.seats;
//                document.getElementById(f.btn).disabled = true;
//            }
//            else {
//                --seats;
//                document.getElementById(f.speaker).innerHTML = f.seats;
//            }
//        }
//}

/*  Definitely not an expert but try this. make it work  >:l

public sealed class SeatsRemaining
{
    //Prevents other classes from instanstiating and prevents subclassing
    private static readonly SeatsRemaining Seats = new SeatsRemaining();

    public static SeatsRemaining GetSeats
    {
        get { return Seats; }
    }

    //Assigns a starting # of seats
    public int MySeatsRemaining()
    {
        int startingSeats = 15;
    }

    //provides logic to decrement the seats upon button click
    public int SeatDecrement()
    {
        //while startingSeats is NOT = 0, Seats are able to be decreased.
        //if [buttonclicked] take starting seats and decrease by 1 seat

        while(!startingSeats==0)
        {
            if (buttonclicked) //this is probably not the way to implement this into the Javascript I know
            {
                startingSeats--;
            } else
            {
                startingSeats = 0;
            }
        }

    }
}

*/