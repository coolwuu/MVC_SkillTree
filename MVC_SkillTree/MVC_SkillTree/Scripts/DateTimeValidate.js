$.validator.addMethod("isexistdatetime",
        function (value, element, param) {
            if (value === false) {
                return true;
            }
                
            var inputDate = value;
            var today = TodayDate();
            console.log(today);
            console.log(inputDate <= today);
            if (inputDate <= today) {
                return true;
            } else {
                return false;
            }
        });
$.validator.unobtrusive.adapters.addSingleVal("isexistdatetime", "input");

function TodayDate() {
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth()+1; //January is 0!
    var yyyy = today.getFullYear();

    if(dd<10) {
        dd = '0' + dd
    }

    if(mm<10) {
        mm = '0' + mm
    }

    today = yyyy + '-' + mm + '-' + dd;
    return today;
}
