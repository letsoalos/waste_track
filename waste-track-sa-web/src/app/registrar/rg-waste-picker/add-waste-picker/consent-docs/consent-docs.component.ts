import { AfterViewInit, Component, ElementRef, Input, ViewChild } from '@angular/core';
import { FormGroup } from '@angular/forms';

declare var PDFViewerApplication: any;

@Component({
  selector: 'app-consent-docs',
  templateUrl: './consent-docs.component.html',
  styleUrls: ['./consent-docs.component.scss']
})
export class ConsentDocsComponent implements AfterViewInit {
  @Input() addWastePickerForm?: FormGroup; 
  @ViewChild('pdfViewerContainer') pdfViewerContainer!: ElementRef | any;

  questions: string[] = [
    'Please confirm that you, as the registrar, have explained the consent to the waste picker.',
    'Please confirm that the waste picker understands and has given consent.',
    'Please confirm with the waste picker that they have not been registered on the system before.',
    'Applicant correctly answered the first question to determine prior knowledge of the work.',
    'Applicant correctly answered the second question to determine prior knowledge of the work.',
    'Applicant correctly answered the third question to determine prior knowledge of the work.'
  ];

  constructor() {}

  ngAfterViewInit(): void {
    const pdfViewerContainer: HTMLElement | any = document.getElementById('pdfViewerContainer');
    const iframe: HTMLElement | any = document.createElement('iframe');
    iframe.src = './assets/docs/ConsentForm.pdf';
    iframe.width = '85%'; 
    iframe.height = '280vh'; 
    iframe.style.border = 'none';
    iframe.style.display = 'block';
    iframe.style.margin = 'auto'; // Center horizontally
    pdfViewerContainer.appendChild(iframe);

     // Check if pdfViewerContainer is available before appending iframe
    if (this.pdfViewerContainer && this.pdfViewerContainer.nativeElement) {
      console.log('pdfViewerContainer is available:', this.pdfViewerContainer.nativeElement);
      this.pdfViewerContainer.nativeElement.appendChild(iframe);
      // Initialize PDF viewer
      iframe.onload = () => {
        iframe.contentWindow.onload = () => {
          PDFViewerApplication.initialize({});
        };
      };
    } else {
      console.error('pdfViewerContainer is not available.');
    }
  }

}
