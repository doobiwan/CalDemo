
(function () {
    $(document).ready(function () {
        $.ajax({
            type: "GET",
            url: "/api/Calendars/",
            contentType: "application/json",
            success: function (data) {
                console.log(data);
                RenderCalendars(data);
            },
            error: function (err) {
                console.log(data);
            }
        });

        $("input#calendar-filter").keyup(function () {
            console.log("input#calendar-filter keyup");
            $.ajax({
                type: "GET",
                url: "/api/Calendars/?$filter=startswith(Name,'" + $("#calendar-filter").val() + "')",
                contentType: "application/json",
                success: function (data) {
                    console.log(data);
                    RenderCalendars(data);
                },
                error: function (err) {
                    console.log(data);
                }
            });
        });
    });

    function RenderCalendars(data) {
        var calendars = { calendars: data };
        var source = $("#calendar-template").html();
        var template = Handlebars.compile(source);
        var html = template(calendars);
        
        $("div#calendar-content").html(html);
    }
})();