import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FormService {
  private submitFormSubject = new BehaviorSubject<void>(undefined);
  submitForm$ = this.submitFormSubject.asObservable();

  constructor() {
    console.log('FormService instantiated.');
  }

  submitForm() {
    console.log('Form submission initiated.');
    this.submitFormSubject.next();
  }
}
