import { AfterContentInit, AfterViewInit, Component, ElementRef, Input, OnInit, ViewChild } from '@angular/core';
import { FormGroup } from '@angular/forms';

declare var PDFViewerApplication: any;

@Component({
  selector: 'app-consent-docs',
  templateUrl: './consent-docs.component.html',
  styleUrls: ['./consent-docs.component.scss']
})
export class ConsentDocsComponent implements AfterViewInit {
  @Input() addWastePickerForm?: FormGroup; 
  @ViewChild('pdfViewerContainer') pdfViewerContainer: ElementRef | any;

  ngAfterViewInit(): void {
    const pdfViewerContainer: HTMLElement | any = document.getElementById('pdfViewerContainer');
    const iframe: HTMLElement | any = document.createElement('iframe');
    iframe.src = './assets/docs/ConsentForm.pdf';
    iframe.width = '100%'; 
    iframe.height = '250vh'; 
    iframe.style.border = 'none';
    iframe.style.display = 'block';
    iframe.style.margin = 'auto'; // Center horizontally
    pdfViewerContainer.appendChild(iframe);

     // Check if pdfViewerContainer is available before appending iframe
    if (this.pdfViewerContainer && this.pdfViewerContainer.nativeElement) {
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
