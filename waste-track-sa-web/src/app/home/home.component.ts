import { Component, OnInit } from '@angular/core';
import { MunicipalityDto } from '../shared/models/municipality';
import { RegistrarService } from '../registrar/registrar.service';
import { DocumentTypeDto, GenderDto, WastePickerDto } from '../shared/models/wastePicker';
import { SortingAreaDto } from '../shared/models/sortingArea';
import { Observable } from 'rxjs';

declare var google: any;

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  municipalities: any | MunicipalityDto[] = [];
  wastePickers: any | WastePickerDto[] = [];
  sortingAreas: any | SortingAreaDto[] = [];
  genders: any | GenderDto[] = [];
  documentTypes: any | DocumentTypeDto[] = [];
  
  totalMunicipalities: number = 0;
  totalWastePickers: number = 0; 
  totalSortingAreas: number = 0; 

  constructor(private registrarService: RegistrarService) { }

  ngOnInit(): void {
    this.loadMunicipality();
    this.loadWastePickerList();
    this.loadSortingArea();
    google.charts.load('current', { packages: ['corechart'] });

  // Wait for the Google Charts API to load before executing the callbacks
  google.charts.setOnLoadCallback(() => {
    this.loadMunicipality();
    this.loadWastePickerList();
    this.loadSortingArea();
    this.loadGenderByWastePicker().subscribe(wastePickers => {
      this.buildChart(wastePickers);
    });
    this.loadDocumentTypeByWastePicker().subscribe(wastePickers => {
      this.buildChart1(wastePickers);
    });
    this.loadRaceByWastePicker().subscribe(wastePickers => {
      this.buildChart2(wastePickers);
    });        
  });
}

  buildChart(wastePickers: WastePickerDto[]) {
    console.log('Building chart with waste pickers:', wastePickers); // Log the waste picker data received
  
    var options = {
      colors: ['#3498db', 'pink', 'green', 'orange'], // Set colors for each column
      title: 'Count waste picker by gender', // Add a title to the chart
      subtitle: 'Based on Gender Id', // Add a subtitle to the chart
      annotations: {
        textStyle: {
          fontSize: 12, // Set font size for annotations
          bold: true, // Make annotations bold
          color: '#000', // Set color for annotations text
          textAlign: 'center', // Align annotations text to center
        },
      },
      legend: {
        position: 'right', // Position the legend at the top
        alignment: 'center', // Align legend items to the center
      },
    };
  
    var renderChart = (Chart: any) => {
      var maleCount = wastePickers.filter(wp => wp.genderId === '1').length;
      var femaleCount = wastePickers.filter(wp => wp.genderId === '2').length;
      var otherCount = wastePickers.filter(wp => wp.genderId === '3').length;
      var nonBinaryCount = wastePickers.filter(wp => wp.genderId === '4').length;
  
      console.log('Male Count:', maleCount);
      console.log('Female Count:', femaleCount);
      console.log('Other Count:', otherCount);
      console.log('Non-binary Count:', nonBinaryCount);
  
      var data = google.visualization.arrayToDataTable([
        ['Gender', 'Count', { role: 'annotation' }], // Include annotation role
        ['Male', maleCount, maleCount.toString()], // Convert count to string for annotation
        ['Female', femaleCount, femaleCount.toString()],
        ['Other', otherCount, otherCount.toString()],
        ['Non-binary', nonBinaryCount, nonBinaryCount.toString()],
      ]);
  
      var chart = new google.visualization.ColumnChart(document.getElementById("divBarChart"));
      chart.draw(data, options); // Pass the options object directly
    };
  
    var barChart = () => new google.visualization.ColumnChart(document.getElementById("divBarChart"));
    var callBack = () => renderChart(barChart);
    google.charts.setOnLoadCallback(callBack);
  }

  buildChart1(wastePickers: WastePickerDto[]) {
    console.log('Building chart with waste pickers:', wastePickers); // Log the waste picker data received
  
    var options = {
      colors: ['#e97f51'], // Set colors for each column
      title: 'Count waste picker by document type', // Add a title to the chart
      subtitle: 'Based on document type Id', // Add a subtitle to the chart
      annotations: {
        textStyle: {
          fontSize: 12, // Set font size for annotations
          bold: true, // Make annotations bold
          color: '#000', // Set color for annotations text
          textAlign: 'center', // Align annotations text to center
        },
      },
      legend: {
        position: 'right', // Position the legend at the top
        alignment: 'center', // Align legend items to the center
      },
    };
  
    var renderChart = (Chart: any) => {
      var saCount = wastePickers.filter(wp => wp.documentTypeId === '1').length;
      var otherCount = wastePickers.filter(wp => wp.documentTypeId === '2').length;
  
  
      var data = google.visualization.arrayToDataTable([
        ['DocumentType', 'Count', { role: 'annotation' }], 
        ['SA ID', saCount, saCount.toString()], 
        ['Other', otherCount, otherCount.toString()],
      ]);
  
      var chart = new google.visualization.ColumnChart(document.getElementById("divDocumentTypeBarChart"));
      chart.draw(data, options);
    };
  
    var barChart = () => new google.visualization.ColumnChart(document.getElementById("divDocumentTypeBarChart"));
    var callBack = () => renderChart(barChart);
    google.charts.setOnLoadCallback(callBack);
  }
  
  buildChart2(wastePickers: WastePickerDto[]) {
    console.log('Building chart with waste pickers:', wastePickers); // Log the waste picker data received
  
    var options = {
      title: 'Count waste picker by race',
      subtitle: 'Based on race Id',
      legend: { position: 'right', alignment: 'center' },
      pieSliceText: 'percentage', // Display percentage labels on slices
      slices: {
        0: { color: '#20c997' }, // Set color for each slice
        1: { color: '#d63384' },
        2: { color: '#0dcaf0' }, // Add more colors as needed
        3: { color: '#ffc107' },
        // Add more color configurations for additional slices
      },
      pieSliceTextStyle: {
        fontSize: 12,
        color: 'white', // Font color of percentage labels
      },
    };
  
    var renderChart = (Chart: any) => {
        var blackCount = wastePickers.filter(wp => wp.raceId === '1').length;
        var whiteCount = wastePickers.filter(wp => wp.raceId === '2').length;
        var colouredCount = wastePickers.filter(wp => wp.raceId === '3').length;
        var indianCount = wastePickers.filter(wp => wp.raceId === '4').length;
    
        console.log('Counts:', blackCount, whiteCount, colouredCount, indianCount);
    
        var data = google.visualization.arrayToDataTable([
            ['Race', 'Count', { role: 'annotation' }], 
            ['Black', blackCount, blackCount.toString()], 
            ['White', whiteCount, whiteCount.toString()],
            ['Coloured', colouredCount, colouredCount.toString()],
            ['Indian', indianCount, indianCount.toString()],
        ]);
    
        console.log('Data:', data);
    
        var chart = new google.visualization.PieChart(document.getElementById("divRacePieChart"));
        chart.draw(data, options);
    };
  
    var barChart = () => new google.visualization.PieChart(document.getElementById("divRacePieChart"));
    var callBack = () => renderChart(barChart);
    google.charts.setOnLoadCallback(callBack);
}






  loadGenderByWastePicker(): Observable<WastePickerDto[]> {
    return this.registrarService.getWastePickers();
  }

  loadDocumentTypeByWastePicker(): Observable<WastePickerDto[]> {
    return this.registrarService.getWastePickers();
  }

  loadRaceByWastePicker(): Observable<WastePickerDto[]> {
    return this.registrarService.getWastePickers();
  }
  
  loadMunicipalityStats(): Observable<MunicipalityDto[]> {
    return this.registrarService.getMunicipality();
  }
  
  
  loadWastePickerList(): void {
    this.registrarService.getWastePickers().subscribe({
      next: (res: any) => {
        this.totalWastePickers = res.length; 
        console.log(this.totalWastePickers);       
      },
      error: (err: any) => {
        console.error('Error loading waste picker:', err);
      }
    });
  }

  loadMunicipality(): void {
    this.registrarService.getMunicipality().subscribe({
      next: (res: any) => { 
        console.log(res);
        // Calculate total count based on array length
        this.totalMunicipalities = res.length;
        console.log(this.totalMunicipalities); // Log the value here
      },
      error: (err: any) => {
        console.error('Error loading municipalities:', err);
      }
    });
  }

  loadSortingArea(): void {
    this.registrarService.getSortingArea().subscribe({
      next: (res: any) => { 
        console.log(res);
        this.totalSortingAreas = res.length;
        console.log(this.totalSortingAreas); 
      },
      error: (err: any) => {
        console.error('Error loading sorting area:', err);
      }
    });
  } 
}
