import { Component, OnInit } from '@angular/core';
import { MunicipalityDto } from 'src/app/shared/models/municipality';
import { MunicipalityService } from '../municipality.service';
import { Router } from '@angular/router';

function actionCellRender(params: any) {
  let eGui = document.createElement("div");

  let editingCells = params.api.getEditingCells();
  let isCurrentRowEditing = editingCells.some((cell: any) => {
    return cell.rowIndex === params.node.rowIndex;
  });

  if (isCurrentRowEditing) {
    eGui.innerHTML = `
    <button class="action-button update" data-action="update">Update</button>
    <button class="action-button cancel" data-action="cancel">Cancel</button>
    `;
  } else {
    eGui.innerHTML = `
      <button class="action-button view btn btn-success" data-action="view">View</button>
    `;
  }

  return eGui;
}

@Component({
  selector: 'app-mu-home',
  templateUrl: './mu-home.component.html',
  styleUrls: ['./mu-home.component.scss']
})
export class MuHomeComponent implements OnInit {
  userId: number = 1;
  municipalities: any | MunicipalityDto[] = [];
  loadingMunicipalities: string = "";
  noRow: string = "";
  public rowData: any[] = [];
  public gridApi: MunicipalityDto[] = [];

  constructor(private municipalityService: MunicipalityService, private router: Router) {}

  ngOnInit(): void {
    this.loadMunicipality();
  }

  loadMunicipality(): void {
    this.municipalityService.getMunicipality().subscribe({
      next: (res) => { 
        console.log(res); // Verify the structure of the received data
        this.rowData = res; // Assign the received data to rowData
      },
      error: (err) => {
        console.log(err);
      }
    });
  }
  

  defaultColDef = {};

  columnDefs = [
    {
      field: 'id',
      headerName: 'Id',
      sortable: true,
      filter: true,
      hide: true,
      floatingFilter: true,
      resizable: true,
      flex: 3,
    },
    {
      field: 'code',
      headerName: 'Code',
      sortable: true,
      filter: true,
      floatingFilter: true,
      resizable: true,
      flex: 2,
    },
    {
      field: 'name',
      headerName: 'Municipal Name',
      sortable: true,
      filter: true,
      floatingFilter: true,
      resizable: true,
      flex: 3,
    },
    {
      field: 'address',
      headerName: 'Address',
      sortable: true,
      filter: true,
      floatingFilter: true,
      resizable: true,
      flex: 6,
    },
    {
      field: 'contacts',
      headerName: 'Contacts',
      sortable: true,
      filter: true,
      floatingFilter: true,
      resizable: true,
      flex: 2,
    },
    {
      field: 'district',
      headerName: 'District',
      sortable: true,
      filter: true,
      floatingFilter: true,
      resizable: true,
      flex: 3,
    },
  
    {
      headerName: 'Action',
      minWidth: 100,
      cellRenderer: actionCellRender,
      editable: false,
      colId: 'action',
      width: 100
    }
  ]

  onGridReady(params: any) {
    this.gridApi = params.api;
  }
}
