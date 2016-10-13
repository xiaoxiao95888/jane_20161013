var CurriculumVitae = {
    viewModel: {
        Model: {
            Name: ko.observable(),
            Phone: ko.observable(),
            Email:  ko.observable()
        }
    }
};
CurriculumVitae.viewModel.Submit = function () {
    $("#luck-dialog").modal({
        keyboard: false,
        show: true
    });
}
CurriculumVitae.viewModel.Luck = function () {
    $("#luck-dialog").modal("hide");
    alert("你中奖了,哦巴拉巴");
}
$(function () {
    ko.applyBindings(CurriculumVitae);
})