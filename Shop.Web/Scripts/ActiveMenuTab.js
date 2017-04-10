$(function () {
    $('.headtable a').filter(function () { return this.href == location.href }).parent().addClass('current').siblings().removeClass('current')
    $('.headtable a').click(function () {
        $(this).parent().addClass('current').siblings().removeClass('current')
    })
})