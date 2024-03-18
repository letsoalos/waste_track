import { AfterContentInit, Component, OnInit } from '@angular/core';
import { MainService } from './main.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'waste-track';
  selectedOption: string | null = null;
  isResetting = false;

  constructor(private srv: MainService){

  }
  
  ngOnInit(): void {
    
  }


  onSelectOption(option: string) {
    console.log('Selected option:', option);
    this.selectedOption = option;
  }

  resetSelectedOption() {
    if (!this.isResetting) {
      console.log('Resetting selected option...');
      this.selectedOption = null;
      this.isResetting = true;
    }
  }  
}
