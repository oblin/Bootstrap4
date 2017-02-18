google.charts.load('current', { 'packages': ['corechart']});
google.charts.setOnLoadCallback(generateChart);

function generateChart() {
    pieChart();
    barChart();
}

function barChart() {
    var barChart = $('#barchart');
    var dataUrl = barChart.data('dataurl');
    $.post(dataUrl, function(d) {
        var data = google.visualization.arrayToDataTable(d);
        var chart = new google.visualization.BarChart(barChart[0]);

        var options = {
            'title': 'Sales per Pepresentative',
            'width': 600,
            'height': 300
        };

        chart.draw(data, options);
    })
}

function pieChart() {
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Products');
    data.addColumn('number', 'Sales');
    data.addRows([
        ['Tofu', 30],
        ['Chai', 10],
        ['Chocolade', 20],
        ['Ipoh Coffee', 40]
    ]);

    var options = {
        'title': 'Quartely Sales',
        'width': 600,
        'height': 300,
        is3D: true,
        colors: ['#d9534f', '#f0ad4e', '#5bc0de', '#5cb85c']
    };

    var chart = new google.visualization.PieChart($('#piechart')[0]);

    // 變更原本的 SGI 格式，改為 PNG 圖檔格式，讓使用者可以用右鍵另存
    google.visualization.events.addListener(chart, 'ready', function() {
        piechart.innerHTML = '<img src="' + chart.getImageURI() + '">';

        // 將可列印的連結放入, Not working on IE & Edge
        document.getElementById('png').innerHTML = '<a href="' + chart.getImageURI() + '">Printable version</a>';
        console.log(piechart.innerHTML);
    });


    chart.draw(data, options);
}