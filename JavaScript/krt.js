function Upload_Rack(dane) {
    var CSV_file = document.getElementById("CSV_file");
    var regex = /^([a-zA-Z0-9\s_\\.\-:])+(.csv|.txt)$/;
    var weight_sum = 0;
    
    if (regex.test(CSV_file.value.toLowerCase())) {
        
        if (typeof (FileReader) != "undefined") {
            var reader = new FileReader();
            
            reader.onload = function (e) {
                var table = document.createElement("table");
                var rows = e.target.result.split("\n");
                for (var i = 0; i < rows.length; i++) {
                    var cells = rows[i].split(";");
                    if (cells.length > 1) {
                        var row = table.insertRow(-1);
                        for (var j = 0; j < cells.length; j++) {
                            if(j % 4 == 0){
                                if(dane == 1){
                                var row_x = table1.insertRow(-1);
                                }

                                if(dane == 2){
                                var row_x = table2.insertRow(-1);
                                }

                                if(dane == 3){
                                var row_x = table3.insertRow(-1);
                                }

                                if(dane == 4){
                                var row_x = table4.insertRow(-1);
                                }

                                if(dane == 5){
                                var row_x = table5.insertRow(-1);
                                }
                                var cell_number = row_x.insertCell(0);
                                var cell_code = row_x.insertCell(1);
                                var cell_type = row_x.insertCell(2);
                                var cell_weight = row_x.insertCell(3);
                                cell_number.innerHTML = cells[j];
                                cell_code.innerHTML = cells[j+1];
                                cell_type.innerHTML = cells[j+2];
                                cell_weight.innerHTML = cells[j+3];
                                weight_sum = weight_sum + parseInt(cells[j+3]);
                            }
                            if(dane == 1){
                                table1_weight = weight_sum;
                            }
                            if(dane == 2){
                                table2_weight = weight_sum;
                            }
                            if(dane == 3){
                                table3_weight = weight_sum;
                            }
                            if(dane == 4){
                                table4_weight = weight_sum;
                            }
                            if(dane == 5){
                                table5_weight = weight_sum;
                            }
                            if (weight_sum > max_weight){
                                if(dane == 1)
                                {
                                document.getElementById("Rack1_header").style.backgroundColor = "red";
                                }
                                if(dane == 2)
                                {
                                document.getElementById("Rack2_header").style.backgroundColor = "red";
                                }
                                if(dane == 3)
                                {
                                document.getElementById("Rack3_header").style.backgroundColor = "red";
                                }
                                if(dane == 4)
                                {
                                document.getElementById("Rack4_header").style.backgroundColor = "red";
                                }
                                if(dane == 5)
                                {
                                document.getElementById("Rack5_header").style.backgroundColor = "red";
                                }
                            }
                            else{
                                if(dane == 1){
                                document.getElementById("Rack1_header").style.backgroundColor = "green";
                                }

                                if(dane == 2){
                                document.getElementById("Rack2_header").style.backgroundColor = "green";
                                }

                                if(dane == 3){
                                document.getElementById("Rack3_header").style.backgroundColor = "green";
                                }

                                if(dane == 4){
                                document.getElementById("Rack4_header").style.backgroundColor = "green";
                                }

                                if(dane == 5){
                                document.getElementById("Rack5_header").style.backgroundColor = "green";
                                }
                            }
                        }
                    }
                }	
            }
            reader.readAsText(CSV_file.files[0]);
        } else {
            alert("Browser does not support HTML5");
        }		
    } else {
        alert("Please upload CSV file");
    }
}

function AddProduct(){
    const input_rack_number = document.getElementById('rack_number');
    const input_code = document.getElementById('code');
    const input_type = document.getElementById('type');
    const input_weight = document.getElementById('weight');

    const output1 = document.getElementById('output1');
    const output2 = document.getElementById('output2');
    const output3 = document.getElementById('output3');
    const output4 = document.getElementById('output4');  

    if(input_rack_number.value == 1){
        var table = document.getElementById("Rack_1");
        table1_weight = table1_weight + parseInt(input_weight.value);
        var row_number = document.getElementById("Rack_1").rows.length-1;
    }
    if(input_rack_number.value == 2){
        var table = document.getElementById("Rack_2");
        table2_weight = table2_weight + parseInt(input_weight.value);
        var row_number = document.getElementById("Rack_2").rows.length-1;
    }
    if(input_rack_number.value == 3){
        var table = document.getElementById("Rack_3");
        table3_weight = table3_weight + parseInt(input_weight.value);
        var row_number = document.getElementById("Rack_3").rows.length-1;
    }
    if(input_rack_number.value == 4){
        var table = document.getElementById("Rack_4");
        table4_weight = table4_weight + parseInt(input_weight.value);
        var row_number = document.getElementById("Rack_4").rows.length-1;
    }
    if(input_rack_number.value == 5){
        var table = document.getElementById("Rack_5");
        table5_weight = table5_weight + parseInt(input_weight.value);
        var row_number = document.getElementById("Rack_5").rows.length-1;
    }


    output1.innerHTML = input_rack_number.value;
    output2.innerHTML = input_code.value;
    output3.innerHTML = input_type.value;
    output4.innerHTML = input_weight.value;

    var row_x = table.insertRow(-1);
    var cell_number = row_x.insertCell(0);
    var cell_code = row_x.insertCell(1);
    var cell_type = row_x.insertCell(2);
    var cell_weight = row_x.insertCell(3);

    cell_number.innerHTML = row_number;
    cell_code.innerHTML = output2.innerHTML;
    cell_type.innerHTML = output3.innerHTML;
    cell_weight.innerHTML = output4.innerHTML;

    if(table1_weight > max_weight){
        document.getElementById("Rack1_header").style.backgroundColor = "red";
    }
    else{
        document.getElementById("Rack1_header").style.backgroundColor = "green";
    }
    if(table2_weight > max_weight){
        document.getElementById("Rack2_header").style.backgroundColor = "red";
    }
    else{
        document.getElementById("Rack2_header").style.backgroundColor = "green";
    }
    if(table3_weight > max_weight){
        document.getElementById("Rack3_header").style.backgroundColor = "red";
    }
    else{
        document.getElementById("Rack3_header").style.backgroundColor = "green";
    }
    if(table4_weight > max_weight){
        document.getElementById("Rack4_header").style.backgroundColor = "red";
    }
    else{
        document.getElementById("Rack4_header").style.backgroundColor = "green";
    }
    if(table5_weight > max_weight){
        document.getElementById("Rack5_header").style.backgroundColor = "red";
    }
    else{
        document.getElementById("Rack5_header").style.backgroundColor = "green";
    }
    
}

