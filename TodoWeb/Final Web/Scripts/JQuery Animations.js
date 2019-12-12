$(document).ready(function () {

    $(".Opciones").click(function () {

        if ($(".OpcionesDownMenu").show) {

            $(".OpcionesDownMenu, .OpcionesParent").fadeOut();

            $(".Opciones").css({

                "background": "#fff"
            });

        }

        $(this).css({

            "background": "#f2f2f2"
        });

        $(this).find(".OpcionesDownMenu, .OpcionesParent").stop().slideToggle();
    });


    function isScrolledIntoView(element) {

        var scrollBottomPosition = $(window).scrollTop() + $(window).height();

        return ($(element).offset().top < scrollBottomPosition);
    }

    function addClassIfVisible(element) {

        $(element).each(function () {

            if (isScrolledIntoView(this)) {

                $(this).addClass("animated fadeInUp");
            }
        });
    }

    addClassIfVisible('.MyItem');

    $(window).scroll(function () {

        addClassIfVisible('.MyItem');

        $(".OpcionesDownMenu").hide();
    });
});