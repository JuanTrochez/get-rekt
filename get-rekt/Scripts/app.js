$(function() {
	$('#rekt-btn').click(function() {
		var videoId = $(this).data('rekt');
		$.ajax({
			url: "http://" + window.location.host + "/rekt/" + videoId, 
			success: function(result){
				console.log(result);
			}
		});
	});
		
});