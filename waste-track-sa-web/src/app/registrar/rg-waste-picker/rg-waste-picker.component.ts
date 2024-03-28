import { Component, OnInit } from '@angular/core';
import { WastePickerDto } from 'src/app/shared/models/wastePicker';
import { RegistrarService } from '../registrar.service';
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
  selector: 'app-rg-waste-picker',
  templateUrl: './rg-waste-picker.component.html',
  styleUrls: ['./rg-waste-picker.component.scss']
})
export class RgWastePickerComponent implements OnInit{
  userId: number = 1;
  loadingWastePickers: string = "";
  noRow: string = "";
  public rowData: any[] = [];
  public gridApi: WastePickerDto[] = [];
  wastePickers: any | WastePickerDto[] = [];

  constructor(private registrarService: RegistrarService, private router: Router) {}

  ngOnInit(): void {
   this.loadWastePickerList();
  }

  loadWastePickerList() {
    this.registrarService.getWastePickers().subscribe({
      next: (res: WastePickerDto[]) => {
        this.rowData = res.filter((picker: WastePickerDto) => picker.isMemberCooperative === false);
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
      headerName: 'Waste-Picker-No',
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
      flex: 4,
    },
    {
      field: 'lastName',
      headerName: 'Surname',
      sortable: true,
      filter: true,
      floatingFilter: true,
      resizable: true,
      flex: 4,
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
      field: 'cellphoneNo',
      headerName: 'Cellphone No',
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
      cellRenderer: function(params: any) {
        console.log('Cell Renderer Params:', params);
        let badgeClass = '';
        let statusText = '';
    
        if (params.value === "true") {
            badgeClass = 'bg-success';
            statusText = 'Active';
        } else if (params.value.toLowerCase() === "updated") {
            badgeClass = 'bg-warning';
            statusText = 'Updated';
        } else if (params.value.toLowerCase() === "suspended") {
          badgeClass = 'bg-danger';
          statusText = 'Suspended';
        } else if (params.value.toLowerCase() === "registered") {
          badgeClass = 'bg-info';
          statusText = 'Registered';
        }
        else {
            badgeClass = 'bg-secondary';
            statusText = 'Not Active';
        }
    
        const badgeElement = document.createElement('span');
        badgeElement.classList.add('badge', badgeClass);
        badgeElement.innerText = statusText;
    
        return badgeElement;
    }, 
    
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

  onCellClicked(params: any) {
    if (params.column.colId === 'action' && params.event.target.dataset.action) {
      let action = params.event.target.dataset.action;
      const editModel: WastePickerDto = {
        id: params.data.id,
        firstName: params.data.firstName,
        lastName: params.data.lastName,
        dob: params.data.dob,
        identityNumber: params.data.identityNumber,
        otherIdentityNumber: params.data.otherIdentityNumber,
        age: params.data.age,
        cellphoneNo: params.data.cellphoneNo,
        altCellphoneNo: params.data.altCellphoneNo,
        potrait: params.data.potrait,
        documentType: params.data.documentType,
        documentTypeId: params.data.documentType,
        wastePickerNo: params.data.wastePickerNo,
        comment: params.data.comment,
        consent: params.data.consent,
        createdBy: params.data.createdBy,
        createdDate: params.data.createdDate,
        lastUpdatedBy: params.data.lastUpdatedBy,
        lastUpdatedDate: params.data.lastUpdatedDate,
        registrationLocation: params.data.registrationLocation,
        gender: params.data.gender,
        genderId: params.data.genderId,
        race: params.data.race,
        raceId: params.data.race,
        isMemberCooperative: params.data.isMemberCooperative,
        cooperative: params.data.cooperative,
        activityStatusId: params.data.activityStatusId,
        lastActivityDate: params.data.lastActivityDate,
        printCount: params.data.printCount,
        manualPrintCount: params.data.manualPrintCount,
        autoPrintCount: params.data.autoPrintCount,
        wastePickerStatus: params.data.wastePickerStatus

      };

      if (action === 'view') {
        this.router.navigate(['registrar/waste-picker/', params.data.id]);
      }
    }
  }


  onGridReady(params: any) {
    this.gridApi = params.api;
  }

}
