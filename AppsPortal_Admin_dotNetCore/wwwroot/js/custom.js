//var url = window.location;
//// Will only work if string in href matches with location
//$('ul.page-sidebar-menu  page-header-fixed > li.nav-item a[href="' + url + '"]').parent().addClass('active');

//// Will also work for relative and absolute hrefs
//$('ul.page-sidebar-menu  page-header-fixed > li.nav-item').filter(function () {
//    return this.href === url;
//}).parent().addClass('active');

//var elems = document.querySelectorAll(".nav-item");

//[].forEach.call(elems, function (el) {
//    //el.classList.add("active");
//    el.click($(this).)
//    })
//});


//$(".nav-item").click(function (e) {
//    $(this).addClass("active").siblings().removeClass("active");
//});

function toggleItem(elem) {
    for (var i = 0; i < elem.length; i++) {
        elem[i].addEventListener("click", function (e) {
            var current = this;
            for (var i = 0; i < elem.length; i++) {
                if (current != elem[i]) {
                    elem[i].classList.remove('active');
                } else if (current.classList.contains('active') === true) {
                    current.classList.remove('active');
                } else {
                    current.classList.add('active')
                }
            }
            e.preventDefault();
        });
    };
}
toggleItem(document.querySelectorAll('.nav-item'));