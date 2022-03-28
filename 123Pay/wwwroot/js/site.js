
var Layout = (() => {
    e = () => {
        Cookies.set("sidenav-state", "pinned"),
        console.log(Cookies.get("sidenav-state")),
        $(".sidenav-toggler").addClass("active"),
        $(".sidenav-toggler").data("action", "sidenav-unpin"),
        $("body").removeClass("g-sidenav-hidden").addClass("g-sidenav-show g-sidenav-pinned"),
        $("body").append('<div class="backdrop d-xl-none" data-action="sidenav-unpin" data-target=' + $("#sidenav-main").data("target") + " />");
    }
    a = () => {
        Cookies.set("sidenav-state", "unpinned"),
        console.log(Cookies.get("sidenav-state")),
        $(".sidenav-toggler").removeClass("active"),
        $(".sidenav-toggler").data("action", "sidenav-pin"),
        $("body").removeClass("g-sidenav-pinned").addClass("g-sidenav-hidden"),
        $("body").find(".backdrop").remove();
    }
    var t = Cookies.get("sidenav-state") ? Cookies.get("sidenav-state") : "pinned";

    console.log(t);


    $(window).width() > 1200 &&
        ("pinned" == t && e(),
            "unpinned" == Cookies.get("sidenav-state") && a(),
            $(window).resize(function () {
                $("body").hasClass("g-sidenav-show") && !$("body").hasClass("g-sidenav-pinned") && $("body").removeClass("g-sidenav-show").addClass("g-sidenav-hidden");
            })),
        $(window).width() < 1200 &&
            ("pinned" == t && e(),
                "unpinned" == Cookies.get("sidenav-state") && a()) &&
        ($("body").removeClass("g-sidenav-hide").addClass("g-sidenav-hidden"),
            $("body").removeClass("g-sidenav-show"),
            $(window).resize(function () {
                $("body").hasClass("g-sidenav-show") && !$("body").hasClass("g-sidenav-pinned") && $("body").removeClass("g-sidenav-show").addClass("g-sidenav-hidden");
            })),
        $("body").on("click", "[data-action]", function (t) {
            t.preventDefault();
            var n = $(this),
                i = n.data("action");
            n.data("target");
            switch (i) {
                case "sidenav-pin":
                    e();
                    break;
                case "sidenav-unpin":
                    a();
                    break;
                case "search-show":
                    n.data("target"),
                        $("body").removeClass("g-navbar-search-show").addClass("g-navbar-search-showing"),
                        setTimeout(function () {
                            $("body").removeClass("g-navbar-search-showing").addClass("g-navbar-search-show");
                        }, 150),
                        setTimeout(function () {
                            $("body").addClass("g-navbar-search-shown");
                        }, 300);
                    break;
                case "search-close":
                    n.data("target"),
                        $("body").removeClass("g-navbar-search-shown"),
                        setTimeout(function () {
                            $("body").removeClass("g-navbar-search-show").addClass("g-navbar-search-hiding");
                        }, 150),
                        setTimeout(function () {
                            $("body").removeClass("g-navbar-search-hiding").addClass("g-navbar-search-hidden");
                        }, 300),
                        setTimeout(function () {
                            $("body").removeClass("g-navbar-search-hidden");
                        }, 500);
            }
        }),
        $(".sidenav").on("mouseenter", () => {
            $("body").hasClass("g-sidenav-pinned") || $("body").removeClass("g-sidenav-hide").removeClass("g-sidenav-hidden").addClass("g-sidenav-show");
        }),
        $(".sidenav").on("mouseleave", () => {
            $("body").hasClass("g-sidenav-pinned") ||
                ($("body").removeClass("g-sidenav-show").addClass("g-sidenav-hide"),
                    setTimeout(function () {
                        $("body").removeClass("g-sidenav-hide").addClass("g-sidenav-hidden");
                    }, 300));
        }),
        $(window).on("load resize", () => {
            $("body").height() < 800 && ($("body").css("min-height", "100vh"), $("#footer-main").addClass("footer-auto-bottom"));
        }),
        () => {
            console.log(isPinned());
        }
})(),
    Navbar = (function () {
        var e = $(".navbar-nav, .navbar-nav .nav"),
            a = $(".navbar .collapse"),
            t = $(".navbar .dropdown");
        a.on({
            "show.bs.collapse": function () {
                var t;
                (t = $(this)).closest(e).find(a).not(t).collapse("hide");
            },
        }),
            t.on({
                "hide.bs.dropdown": function () {
                    var e, a;
                    (e = $(this)),
                        (a = e.find(".dropdown-menu")).addClass("close"),
                        setTimeout(function () {
                            a.removeClass("close");
                        }, 200);
                },
            });
    })(),
    NavbarCollapse = (function () {
        $(".navbar-nav");
        var e = $(".navbar .navbar-custom-collapse");
        e.length &&
            (e.on({
                "hide.bs.collapse": function () {
                    e.addClass("collapsing-out");
                },
            }),
                e.on({
                    "hidden.bs.collapse": function () {
                        e.removeClass("collapsing-out");
                    },
                }));
    })();

var Loading = (e) => {
    if (e) {
        $("div.spanner").addClass("show");
        $("div.overlay").addClass("show");
    } else {
        $("div.spanner").removeClass("show");
        $("div.overlay").removeClass("show");
    }
};

var InitialAvatar = () => {
    var colors = ["#1abc9c", "#2ecc71", "#3498db", "#9b59b6", "#34495e", "#16a085", "#27ae60", "#2980b9", "#8e44ad", "#2c3e50", "#f1c40f", "#e67e22", "#e74c3c", "#95a5a6", "#f39c12", "#d35400", "#c0392b", "#bdc3c7", "#7f8c8d"];

    var avatarElement = $('.avatar-initials'),
        avatarWidth = avatarElement.attr('width'),
        avatarHeight = avatarElement.attr('height'),

        name = avatarElement.data('name'),
        initials = '',

        charIndex = initials.charCodeAt(0) - 65,
        colorIndex = charIndex % 19,
        arr = name.split(' ');


    $.each(arr, (i, val) => {
        initials += val.charAt(0).toUpperCase();
    });

    charIndex = initials.charCodeAt(0) - 65,
        colorIndex = charIndex % 19;

    avatarElement.css({
        'background-color': colors[colorIndex],
        'width': avatarWidth,
        'height': avatarHeight,
        'font': avatarWidth / 2 + "px Arial",
        'color': '#FFF',
        'textAlign': 'center',
        'lineHeight': avatarHeight + 'px',
        'borderRadius': '50%'
    })
        .html(initials);
};

InitialAvatar();

function Toast(title, message, color) {
    var element = '<div class="toast" role="alert" aria-live="assertive" aria-atomic="true" style="min-width: 400px;background:#e8eaed">' +
        '<div class="toast-header" style="font-size:20px;background:' + color + '">' +
        '        <strong class="mr-auto text-white">' + title + '</strong>' +
        '        <small class="text-muted"></small>' +
        '        <button type="button" class="ml-2 mb-1 close" data-dismiss="toast" aria-label="Close">' +
        '            <span class="text-white" aria-hidden="true">&times;</span>' +
        '        </button>' +
        '</div>' +
        '    <div class="toast-body" style="text-align: center;padding:50px 25px 50px 25px"><strong style="font-size:20px" class="text-black">' + message + '</strong></div>' +
        '</div>';
    $('#toast-area').append(element);
    $('.toast').toast({ delay: 5000 });
    $('.toast').toast('show');
    $('.toast').on('hidden.bs.toast', function () {
        $(this).toast('dispose');
        $(this).remove();
    });
}