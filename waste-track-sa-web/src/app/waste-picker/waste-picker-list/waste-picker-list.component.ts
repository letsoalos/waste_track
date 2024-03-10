import { Component, OnInit } from '@angular/core';
import { WastePickerDto } from 'src/app/shared/models/wastePicker';
import { WastePickerService } from '../waste-picker.service';

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
  selector: 'app-waste-picker-list',
  templateUrl: './waste-picker-list.component.html',
  styleUrls: ['./waste-picker-list.component.scss']
})
export class WastePickerListComponent implements OnInit {

  userId: number = 1;
  loadingWastePickers: string = "";
  noRow: string = "";
  public rowData: any[] = [];
  public gridApi: WastePickerDto[] = [];
  wastePickers: any | WastePickerDto[] = [];
  

  constructor(private wastePickerService: WastePickerService) {}


  ngOnInit(): void {
   this.geAlltWastePickers();
  }

  geAlltWastePickers() {
    this.wastePickerService.getWastePickers().subscribe({
      next: (res) => {
        this.wastePickers = res;
        this.rowData = this.wastePickers;
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
      headerName: 'id',
      sortable: true,
      filter: true,
      hide: true,
      floatingFilter: true,
      resizable: true,
      flex: 3,
    },
    {
      field: 'wastePickerNo',
      headerName: 'Waste Picker No',
      sortable: true,
      filter: true,
      floatingFilter: true,
      resizable: true,
      flex: 3,
    },
    {
      field: 'firstName',
      headerName: 'Name',
      sortable: true,
      filter: true,
      floatingFilter: true,
      resizable: true,
      flex: 3,
    },
    {
      field: 'lastName',
      headerName: 'Surname',
      sortable: true,
      filter: true,
      floatingFilter: true,
      resizable: true,
      flex: 3,
    },
    {
      field: 'gender',
      headerName: 'Gender',
      sortable: true,
      filter: true,
      floatingFilter: true,
      resizable: true,
      flex: 3,
    },
    {
      field: 'dob',
      headerName: 'DOB',
      sortable: true,
      filter: true,
      floatingFilter: true,
      resizable: true,
      flex: 3,
    },
    {
      field: 'cellphoneNo',
      headerName: 'Cellphone No',
      sortable: true,
      filter: true,
      floatingFilter: true,
      resizable: true,
      flex: 3,
    },    
    {
      field: 'registrationLocation',
      headerName: 'Registration Location',
      sortable: true,
      filter: true,
      floatingFilter: true,
      resizable: true,
      flex: 3,
    },
    {
      field: 'wastePickerStatus',
      headerName: 'Status',
      sortable: true,
      filter: true,
      // cellRenderer: function(params: any) {
      //   if(params.value === "true") {
      //     return '<span class="badge badge-success">Active</span>';
      //   } else {
      //     return '<span class="badge badge-danger">Not Active</span>';
      //   }
      // },
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
