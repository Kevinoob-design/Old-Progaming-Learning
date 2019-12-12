$(document).ready(function () {

    function isScrolledIntoView(element) {

        var scrollBottomPosition = $(window).scrollTop() + $(window).height();

        return ($(element).offset().top < scrollBottomPosition);
    }

    function addClassIfVisible(element) {

        $(element).each(function () {

            if (isScrolledIntoView(this)) {

                if ($(this).hasClass('.AnimationFinish')) {

                    $(this).removeClass('.animated fadeInUp');

                } else {

                    $(this).addClass("animated fadeInUp");

                    $(this).one('webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend', function () {

                        $(this).addClass('.AnimationFinish');
                    });
                }
            }
        });
    }

    addClassIfVisible('.Secondury-Content');

    $(window).scroll(function () {

        addClassIfVisible('.Secondury-Content');

    });

    $('.Secondury-Content').one('webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend', function () {

        $('.Secondury-Content').hover(function () {

            $(this).addClass('.AnimationFinish');
            $(this).removeClass('.animated fadeInUp');
        })
    });
});
