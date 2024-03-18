import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MainService {
  private selectedOptionSubject = new BehaviorSubject<string>('');
  public selectedOption$ = this.selectedOptionSubject.asObservable();
  constructor() { }

  setPageNameOption(title: string): void {
    this.selectedOptionSubject.next(title);
  }
}
