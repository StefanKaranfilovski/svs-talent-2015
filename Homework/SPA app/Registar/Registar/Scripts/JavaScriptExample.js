 $(function () {
        $.ajax({
            type: "GET",
            url: "/Home/FillSearchBikes",
            datatype: "json",
            success: function (data) {
                $.each(data, function (index, item) {

                    var tablerow = "<tr><td>" + item.BikeOwnerId +
                                       "</td><td>" + item.RegNumber +
                                       "</td><td>" + item.Producer +
                                       "</td><td>" + item.Model +
                                       "</td><td>" + item.Colour +
                                       "</td><td>" + item.City +
                                       "</td><td>" + item.SpeedsCount + "</td></tr>";
     
                    $("#biketable > tbody").append(tablerow);
                });
            }
        });
    });