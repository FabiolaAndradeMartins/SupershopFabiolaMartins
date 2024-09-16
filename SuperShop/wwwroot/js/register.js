$(document).ready(() => {
    $("#CountryId").change(() => {
        $("#CityId").empty();
        let urlPath = window.location.protocol + "//" + window.location.host + '/Account/GetCitiesAsync';
        $.ajax({
            url: urlPath,
            type: 'POST',
            dataType: 'json',
            data: { countryId: $("#CountryId").val() },
            success: (cities) => {
                $("#CityId").append('<option value="0">(Select a city...)</option>');
                $.each(cities,  (i, city) => {
                    $("#CityId").append('<option value="'
                        + city.id + '">'
                        + city.name + '</option>');
                });
            },
            error: (ex) => {
                debugger;
                alert('Failed to retrieve cities.' + ex)
            }
        });
        return false;
    })
}); 