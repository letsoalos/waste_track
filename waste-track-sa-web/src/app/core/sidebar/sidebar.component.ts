import { Component, Input, OnChanges, OnInit } from '@angular/core';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss']
})
export class SidebarComponent implements OnChanges{
   @Input() selectedOption: string | null = null;
   isCollapsed = true;

  ngOnChanges(): void {
    console.log('Selected option in SidebarComponent:', this.selectedOption);
  }
 

  onSelectOption(option: string) {
    this.selectedOption = option;
    console.log('Selected option:', this.selectedOption);
  }

  togglePanel(): void {
    this.isCollapsed = !this.isCollapsed;
  }
}
