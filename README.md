# How-to-programmatically-search-and-highlight-a-text-in-wpf-editcontrol
This guide explains how to **search and highlight text programmatically** in the **Syncfusion WPF EditControl**. The EditControl is a powerful text editor component that supports syntax highlighting, code editing, and advanced text manipulation features. In many scenarios, developers need to implement custom search functionality to locate specific words or phrases and visually highlight them for better user experience.

## Why Use Programmatic Search?
Programmatic search allows developers to:
- Automate text highlighting based on user input or predefined keywords.
- Enhance productivity by quickly locating important sections in large documents.
- Provide advanced features like case-sensitive search, whole-word matching, and multi-occurrence highlighting.

## Implementation Steps
1. **Access the EditControl**: Ensure the EditControl instance is available in your WPF application.
2. **Use Built-in Methods**: Syncfusion EditControl provides APIs such as `FindText` and `HighlightText` to perform search and highlight operations.
3. **Customize Search Options**:
   - Enable case sensitivity if required.
   - Highlight all occurrences or just the first match.
4. **Apply Highlighting**: Once the text is found, apply a visual style (e.g., background color) to make the highlighted text stand out.

## Practical Use Cases
- Code editors that highlight keywords or errors.
- Document viewers that allow quick navigation to specific terms.
- Applications requiring dynamic text analysis.

For a detailed example and step-by-step instructions, refer to the official Syncfusion Knowledge Base article:

KB article - [How-to-programmatically-search-and-highlight-a-text-in-wpf-editcontrol](https://www.syncfusion.com/kb/11736/how-to-programmatically-search-and-highlight-a-text-in-wpf-edit-control)

This approach is ideal for developers building WPF applications that require advanced text editing and search capabilities.
