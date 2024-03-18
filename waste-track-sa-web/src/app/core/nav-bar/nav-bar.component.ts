import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.scss']
})
export class NavBarComponent {
  @Output() optionSelected = new EventEmitter<string>();
  @Output() resetSelectedOption = new EventEmitter<void>();

  selectOption(option: string) {
    this.optionSelected.emit(option);
    this.resetSelectedOption.emit(); 
  }

    // Method to trigger resetting the selected option
    resetOption() {
      this.resetSelectedOption.emit();
    }

}
