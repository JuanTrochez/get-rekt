$(function() {
	$('#rekt-btn').click(function() {
		var videoId = $(this).data('rekt');
		$.ajax({
			url: "http://" + window.location.host + "/rekt/" + videoId, 
			success: function(result){
				console.log(result);
				if (result.data.Rekt == 1) {
					var total = +$(".detail .rekt").text() + 1;
					$(".detail .rekt").text(total);
				} else {
					var total = +$(".detail .rekt").text() - 1;
					$(".detail .rekt").text(total);
				}
			}
		});
	});

	$('.publish-video button').click(function() {
		var videoId = $(this).data('publish');
		var _this = $(this);
		$.ajax({
			url: "http://" + window.location.host + "/publish/" + videoId, 
			success: function(result){
				console.log(result);
				if (result.data.Published == 1) {
					_this.removeClass();
					_this.addClass("btn btn-info back-blue");
					_this.text("ON");
				} else {					
					_this.removeClass();
					_this.addClass("btn btn-warning back-y");
					_this.text("OFF");
				}
			}
		});
	});

	$('#delete-btn').click(function() {
		var videoId = $(this).data('delete');
		$.ajax({
			url: "http://" + window.location.host + "/delete/" + videoId, 
			success: function(result){
				console.log(result);
				alert("La vidéo a été supprimée");
			}
		});
	});
		
});