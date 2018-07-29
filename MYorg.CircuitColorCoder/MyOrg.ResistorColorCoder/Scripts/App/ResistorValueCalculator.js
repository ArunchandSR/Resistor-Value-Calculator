function CalculateResistorValue() {
    $("#divResult").html("");

    var ColorBands = {
        BandA: $('#bandA').find(":selected").text(),
        BandB: $('#bandB').find(":selected").text(),
        BandC: $('#bandC').find(":selected").text(),
        BandD: $('#bandD').find(":selected").text()
      };

    $.ajax({
        url: "/ResistorColorCodeCalculator/CalculateResistorValue",
        data: JSON.stringify(ColorBands),
        type: "POST",
        contentType: "application/json",
        dataType: "json",
        success: function (output) {
            $("#divResult").html(output.Result);
        },
        error: function (errormessage) {
            $("#divResult").html("Error in Processing Request");
        }
    });

    return false;
}