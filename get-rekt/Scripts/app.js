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

	$('#publish-btn').click(function() {
		var videoId = $(this).data('publish');
		$.ajax({
			url: "http://" + window.location.host + "/publish/" + videoId, 
			success: function(result){
				console.log(result);
			}
		});
	});

	$('#delete-btn').click(function() {
		var videoId = $(this).data('delete');
		$.ajax({
			url: "http://" + window.location.host + "/delete/" + videoId, 
			success: function(result){
				console.log(result);
			}
		});
	});
		
});