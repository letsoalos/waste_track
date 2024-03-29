import { Component, EventEmitter, Input, Output } from '@angular/core';
import { AccountService } from 'src/app/account/account.service';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.scss']
})
export class NavBarComponent {
  @Input() selectedOption: string | null = null;
  @Output() optionSelected = new EventEmitter<string>();
  @Output() resetMainWindow = new EventEmitter<void>();

  constructor(public accountService: AccountService) {}

  selectOption(option: string) {
    this.optionSelected.emit(option);
    this.resetMainWindow.emit();
  }
}
